﻿using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Records;
using Noggog;

namespace Mutagen.Bethesda.Plugins.Analysis.DI;

public class RecordCompactionCompatibilityDetector
{
    public bool IsSmallMasterCompatible(IModGetter mod)
    {
        var range = GetSmallMasterRange(mod);
        if (range == null) return false;

        return IsCompatible(mod, range.Value);
    }
    
    public bool IsMediumMasterCompatible(IModGetter mod)
    {
        var range = GetMediumMasterRange(mod);
        if (range == null) return false;

        return IsCompatible(mod, range.Value);
    }

    public RangeUInt32? GetSmallMasterRange(IModGetter mod)
    {
        if (!mod.CanBeSmallMaster) return null;
        var lowerRange = mod.GetDefaultInitialNextFormID(forceUseLowerFormIDRanges: null);
        return new RangeUInt32(lowerRange, FormID.SmallIdMask);
    }

    public RangeUInt32? GetMediumMasterRange(IModGetter mod)
    {
        if (!mod.CanBeMediumMaster) return null;
        var lowerRange = mod.GetDefaultInitialNextFormID(forceUseLowerFormIDRanges: null);
        return new RangeUInt32(lowerRange, FormID.MediumIdMask);
    }

    public RangeUInt32? GetRange(IModGetter mod)
    {
        if (mod.IsMediumMaster)
        {
            return GetMediumMasterRange(mod);
        }
        if (mod.IsSmallMaster)
        {
            return GetSmallMasterRange(mod);
        }

        return null;
    }
    
    private bool IsCompatible(IModGetter modGetter, RangeUInt32 range)
    {
        ModKey patchModKey = modGetter.ModKey;
        
        foreach (var rec in modGetter.EnumerateMajorRecords())
        {
            if (!rec.FormKey.ModKey.Equals(patchModKey)) continue;
            if (!range.IsInRange(rec.FormKey.ID)) return false;
        }

        return true;
    }
    
    public void ThrowIfIncompatible(IModGetter mod)
    {
        RangeUInt32? formIdRange = GetRange(mod);

        if (formIdRange == null) return;
        
        foreach (var rec in mod.EnumerateMajorRecords())
        {
            ThrowIfIncompatible(mod, formIdRange.Value, rec);
        }
    }
    
    public void ThrowIfIncompatible(
        IModGetter mod, 
        RangeUInt32 range,
        IMajorRecordGetter rec)
    {
        ModKey patchModKey = mod.ModKey;
        
        if (!rec.FormKey.ModKey.Equals(patchModKey)) return;
        if (!range.IsInRange(rec.FormKey.ID))
        {
            throw new FormIDCompactionOutOfBoundsException(
                small: mod.IsSmallMaster,
                Medium: mod.IsMediumMaster,
                range: range,
                outOfBounds: rec
            );
        }
    }
}