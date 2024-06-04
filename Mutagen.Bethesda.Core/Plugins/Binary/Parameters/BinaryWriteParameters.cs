using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Strings;
using Mutagen.Bethesda.Plugins.Records;
using Noggog;

namespace Mutagen.Bethesda.Plugins.Binary.Parameters;

/// <summary>
/// Parameter object for customizing binary export job instructions
/// </summary>
public sealed class BinaryWriteParameters
{
    public static readonly BinaryWriteParameters Default = new();

    /// <summary>
    /// Flag to specify what logic to use to keep a mod's ModKey in sync with its path
    /// </summary>
    public ModKeyOption ModKey = ModKeyOption.ThrowIfMisaligned;

    /// <summary>
    /// Logic to use to keep a mod's master list content in sync<br/>
    /// This setting is just used to sync the contents of the list, not the order
    /// </summary>
    public MastersListContentOption MastersListContent = MastersListContentOption.Iterate;

    /// <summary>
    /// Logic to use to keep a mod's record count in sync
    /// </summary>
    public RecordCountOption RecordCount = RecordCountOption.Iterate;

    /// <summary>
    /// Logic to use to keep a mod's master list ordering in sync<br/>
    /// This setting is just used to sync the order of the list, not the content
    /// </summary>
    public AMastersListOrderingOption MastersListOrdering { get; set; } = new MastersListOrderingEnumOption();

    /// <summary>
    /// Logic to use to locate a mod header's next formID to use based on the record content
    /// </summary>
    public NextFormIDOption NextFormID { get; set; } = NextFormIDOption.Iterate;

    /// <summary>
    /// Logic to use to determine minimum allowed FormID.  Null is default behavior, which checks header version
    /// </summary>
    public AMinimumFormIdOption MinimumFormID { get; set; } = new AutomaticLowerFormIdRangeOption();

    /// <summary>
    /// Logic to use to ensure a mod's formIDs are unique.<br/>
    /// If there is a collision, an ArgumentException will be thrown.
    /// </summary>
    public FormIDUniquenessOption FormIDUniqueness { get; set; } = FormIDUniquenessOption.Iterate;

    /// <summary>
    /// Logic to use to ensure a mod's formIDs are compacted according to a mod's header flags.<br/>
    /// If there is a record outside the allowed setting, an ArgumentException will be thrown.
    /// </summary>
    public FormIDCompactionOption FormIDCompaction { get; set; } = FormIDCompactionOption.Iterate;

    /// <summary>
    /// Logic to use to ensure a mod's master flag matches the specified ModKey
    /// </summary>
    public MasterFlagOption MasterFlag { get; set; } = MasterFlagOption.ChangeToMatchModKey;

    /// <summary>
    /// Optional StringsWriter override, for mods that are able to localize.
    /// </summary>
    public StringsWriter? StringsWriter { get; set; }
        
    /// <summary>
    /// If not localizable mod that has localization off, which language to output as the embedded strings.
    /// If left null, each individual TranslatedString" will use its current TargetLanguage
    /// </summary>
    public Language? TargetLanguageOverride { get; set; }

    /// <summary>
    /// If a FormID has all zeros for the ID, but a non-zero mod index, then set mod index to zero as well.
    /// </summary>
    public bool CleanNulls { get; set; } = true;

    /// <summary>
    /// Encoding overrides to use for embedded strings
    /// </summary>
    public EncodingBundle? Encodings { get; set; }

    /// <summary>
    /// A class representing how to handle when lower formID ranges are used in a non-allowed way. <br />
    /// Typically this occurs when the lower ranges are used without any masters present.
    /// By default
    /// </summary>
    public ALowerRangeDisallowedHandlerOption LowerRangeDisallowedHandler { get; set; } = new AddPlaceholderMasterIfLowerRangeDisallowed();

    /// <summary>
    /// Aligns a mod's ModKey to a path's implied ModKey.
    /// Will adjust its logic based on the MasterFlagSync option:
    ///  - ThrowIfMisaligned:  If the path and mod do not match, throw.
    ///  - CorrectToPath:  If the path and mod do not match, use path's key.
    /// </summary>
    /// <param name="mod">Mod to check and adjust</param>
    /// <param name="path">Path to compare to</param>
    /// <returns>ModKey to use</returns>
    /// <exception cref="ArgumentException">If misaligned and set to ThrowIfMisaligned</exception>
    public ModKey RunMasterMatch(IModGetter mod, FilePath path)
    {
        if (ModKey == ModKeyOption.NoCheck) return mod.ModKey;
        if (!Plugins.ModKey.TryFromNameAndExtension(path.Name, out var pathModKey))
        {
            throw new ArgumentException($"Could not convert path to a ModKey to compare against: {Path.GetFileName(path)}");
        }
        switch (ModKey)
        {
            case ModKeyOption.ThrowIfMisaligned:
                if (mod.ModKey != pathModKey)
                {
                    throw new ArgumentException($"ModKeys were misaligned: {mod.ModKey} != {pathModKey}.  " +
                                                $"Export to a file that matches the mod object's ModKey, or " +
                                                $"modify your {nameof(BinaryWriteParameters)}.{nameof(ModKey)} parameters " +
                                                $"to override this behavior.");
                }
                return mod.ModKey;
            case ModKeyOption.CorrectToPath:
                return pathModKey;
            default:
                throw new NotImplementedException();
        }
    }
}