/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Skyrim.Internals;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class Portal :
        IEquatable<IPortalGetter>,
        ILoquiObjectSetter<Portal>,
        IPortal
    {
        #region Ctor
        public Portal()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Origin
        public FormLink<IPlacedObjectGetter> Origin { get; set; } = new FormLink<IPlacedObjectGetter>();
        #endregion
        #region Destination
        public FormLink<IPlacedObjectGetter> Destination { get; set; } = new FormLink<IPlacedObjectGetter>();
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PortalMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPortalGetter rhs)) return false;
            return ((PortalCommon)((IPortalGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPortalGetter? obj)
        {
            return ((PortalCommon)((IPortalGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PortalCommon)((IPortalGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Origin = initialValue;
                this.Destination = initialValue;
            }

            public Mask(
                TItem Origin,
                TItem Destination)
            {
                this.Origin = Origin;
                this.Destination = Destination;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Origin;
            public TItem Destination;
            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!object.Equals(this.Origin, rhs.Origin)) return false;
                if (!object.Equals(this.Destination, rhs.Destination)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Origin);
                hash.Add(this.Destination);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Origin)) return false;
                if (!eval(this.Destination)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Origin)) return true;
                if (eval(this.Destination)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new Portal.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Origin = eval(this.Origin);
                obj.Destination = eval(this.Destination);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(Portal.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, Portal.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(Portal.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Origin ?? true)
                    {
                        fg.AppendItem(Origin, "Origin");
                    }
                    if (printMask?.Destination ?? true)
                    {
                        fg.AppendItem(Destination, "Destination");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? Origin;
            public Exception? Destination;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                Portal_FieldIndex enu = (Portal_FieldIndex)index;
                switch (enu)
                {
                    case Portal_FieldIndex.Origin:
                        return Origin;
                    case Portal_FieldIndex.Destination:
                        return Destination;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                Portal_FieldIndex enu = (Portal_FieldIndex)index;
                switch (enu)
                {
                    case Portal_FieldIndex.Origin:
                        this.Origin = ex;
                        break;
                    case Portal_FieldIndex.Destination:
                        this.Destination = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                Portal_FieldIndex enu = (Portal_FieldIndex)index;
                switch (enu)
                {
                    case Portal_FieldIndex.Origin:
                        this.Origin = (Exception?)obj;
                        break;
                    case Portal_FieldIndex.Destination:
                        this.Destination = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Origin != null) return true;
                if (Destination != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (this.Overall != null)
                    {
                        fg.AppendLine("Overall =>");
                        fg.AppendLine("[");
                        using (new DepthWrapper(fg))
                        {
                            fg.AppendLine($"{this.Overall}");
                        }
                        fg.AppendLine("]");
                    }
                    ToString_FillInternal(fg);
                }
                fg.AppendLine("]");
            }
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(Origin, "Origin");
                fg.AppendItem(Destination, "Destination");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Origin = this.Origin.Combine(rhs.Origin);
                ret.Destination = this.Destination.Combine(rhs.Destination);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            public bool Origin;
            public bool Destination;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Origin = defaultOn;
                this.Destination = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((Origin, null));
                ret.Add((Destination, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public IEnumerable<FormLinkInformation> ContainedFormLinks => PortalCommon.Instance.GetContainedFormLinks(this);
        public void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => PortalSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => PortalBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PortalBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public static Portal CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new Portal();
            ((PortalSetterCommon)((IPortalGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out Portal item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(frame, recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((PortalSetterCommon)((IPortalGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static Portal GetNew()
        {
            return new Portal();
        }

    }
    #endregion

    #region Interface
    public partial interface IPortal :
        IFormLinkContainer,
        ILoquiObjectSetter<IPortal>,
        IPortalGetter
    {
        new FormLink<IPlacedObjectGetter> Origin { get; set; }
        new FormLink<IPlacedObjectGetter> Destination { get; set; }
    }

    public partial interface IPortalGetter :
        ILoquiObject,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IPortalGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => Portal_Registration.Instance;
        FormLink<IPlacedObjectGetter> Origin { get; }
        FormLink<IPlacedObjectGetter> Destination { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PortalMixIn
    {
        public static void Clear(this IPortal item)
        {
            ((PortalSetterCommon)((IPortalGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static Portal.Mask<bool> GetEqualsMask(
            this IPortalGetter item,
            IPortalGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PortalCommon)((IPortalGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IPortalGetter item,
            string? name = null,
            Portal.Mask<bool>? printMask = null)
        {
            return ((PortalCommon)((IPortalGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IPortalGetter item,
            FileGeneration fg,
            string? name = null,
            Portal.Mask<bool>? printMask = null)
        {
            ((PortalCommon)((IPortalGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPortalGetter item,
            IPortalGetter rhs)
        {
            return ((PortalCommon)((IPortalGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IPortal lhs,
            IPortalGetter rhs)
        {
            ((PortalSetterTranslationCommon)((IPortalGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPortal lhs,
            IPortalGetter rhs,
            Portal.TranslationMask? copyMask = null)
        {
            ((PortalSetterTranslationCommon)((IPortalGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPortal lhs,
            IPortalGetter rhs,
            out Portal.ErrorMask errorMask,
            Portal.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PortalSetterTranslationCommon)((IPortalGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = Portal.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPortal lhs,
            IPortalGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PortalSetterTranslationCommon)((IPortalGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static Portal DeepCopy(
            this IPortalGetter item,
            Portal.TranslationMask? copyMask = null)
        {
            return ((PortalSetterTranslationCommon)((IPortalGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static Portal DeepCopy(
            this IPortalGetter item,
            out Portal.ErrorMask errorMask,
            Portal.TranslationMask? copyMask = null)
        {
            return ((PortalSetterTranslationCommon)((IPortalGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static Portal DeepCopy(
            this IPortalGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PortalSetterTranslationCommon)((IPortalGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IPortal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PortalSetterCommon)((IPortalGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum Portal_FieldIndex
    {
        Origin = 0,
        Destination = 1,
    }
    #endregion

    #region Registration
    public partial class Portal_Registration : ILoquiRegistration
    {
        public static readonly Portal_Registration Instance = new Portal_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 302,
            version: 0);

        public const string GUID = "72c87f66-75f5-469d-8606-5403337881b0";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(Portal.Mask<>);

        public static readonly Type ErrorMaskType = typeof(Portal.ErrorMask);

        public static readonly Type ClassType = typeof(Portal);

        public static readonly Type GetterType = typeof(IPortalGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPortal);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.Portal";

        public const string Name = "Portal";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(PortalBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    public partial class PortalSetterCommon
    {
        public static readonly PortalSetterCommon Instance = new PortalSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPortal item)
        {
            ClearPartial();
            item.Origin = FormLink<IPlacedObjectGetter>.Null;
            item.Destination = FormLink<IPlacedObjectGetter>.Null;
        }
        
        #region Mutagen
        public void RemapLinks(IPortal obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            obj.Origin = obj.Origin.Relink(mapping);
            obj.Destination = obj.Destination.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IPortal item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: PortalBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class PortalCommon
    {
        public static readonly PortalCommon Instance = new PortalCommon();

        public Portal.Mask<bool> GetEqualsMask(
            IPortalGetter item,
            IPortalGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new Portal.Mask<bool>(false);
            ((PortalCommon)((IPortalGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPortalGetter item,
            IPortalGetter rhs,
            Portal.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Origin = item.Origin.Equals(rhs.Origin);
            ret.Destination = item.Destination.Equals(rhs.Destination);
        }
        
        public string ToString(
            IPortalGetter item,
            string? name = null,
            Portal.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            IPortalGetter item,
            FileGeneration fg,
            string? name = null,
            Portal.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"Portal =>");
            }
            else
            {
                fg.AppendLine($"{name} (Portal) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IPortalGetter item,
            FileGeneration fg,
            Portal.Mask<bool>? printMask = null)
        {
            if (printMask?.Origin ?? true)
            {
                fg.AppendItem(item.Origin.FormKey, "Origin");
            }
            if (printMask?.Destination ?? true)
            {
                fg.AppendItem(item.Destination.FormKey, "Destination");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPortalGetter? lhs,
            IPortalGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!lhs.Origin.Equals(rhs.Origin)) return false;
            if (!lhs.Destination.Equals(rhs.Destination)) return false;
            return true;
        }
        
        public virtual int GetHashCode(IPortalGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Origin);
            hash.Add(item.Destination);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return Portal.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IPortalGetter obj)
        {
            yield return FormLinkInformation.Factory(obj.Origin);
            yield return FormLinkInformation.Factory(obj.Destination);
            yield break;
        }
        
        #endregion
        
    }
    public partial class PortalSetterTranslationCommon
    {
        public static readonly PortalSetterTranslationCommon Instance = new PortalSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPortal item,
            IPortalGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)Portal_FieldIndex.Origin) ?? true))
            {
                item.Origin = new FormLink<IPlacedObjectGetter>(rhs.Origin.FormKey);
            }
            if ((copyMask?.GetShouldTranslate((int)Portal_FieldIndex.Destination) ?? true))
            {
                item.Destination = new FormLink<IPlacedObjectGetter>(rhs.Destination.FormKey);
            }
        }
        
        #endregion
        
        public Portal DeepCopy(
            IPortalGetter item,
            Portal.TranslationMask? copyMask = null)
        {
            Portal ret = (Portal)((PortalCommon)((IPortalGetter)item).CommonInstance()!).GetNew();
            ((PortalSetterTranslationCommon)((IPortalGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public Portal DeepCopy(
            IPortalGetter item,
            out Portal.ErrorMask errorMask,
            Portal.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            Portal ret = (Portal)((PortalCommon)((IPortalGetter)item).CommonInstance()!).GetNew();
            ((PortalSetterTranslationCommon)((IPortalGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = Portal.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public Portal DeepCopy(
            IPortalGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            Portal ret = (Portal)((PortalCommon)((IPortalGetter)item).CommonInstance()!).GetNew();
            ((PortalSetterTranslationCommon)((IPortalGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    public partial class Portal
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Portal_Registration.Instance;
        public static Portal_Registration Registration => Portal_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PortalCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return PortalSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PortalSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPortalGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IPortalGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IPortalGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PortalBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static PortalBinaryWriteTranslation Instance = new PortalBinaryWriteTranslation();

        public static void WriteEmbedded(
            IPortalGetter item,
            MutagenWriter writer)
        {
            Mutagen.Bethesda.Binary.FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Origin);
            Mutagen.Bethesda.Binary.FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Destination);
        }

        public void Write(
            MutagenWriter writer,
            IPortalGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IPortalGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class PortalBinaryCreateTranslation
    {
        public readonly static PortalBinaryCreateTranslation Instance = new PortalBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IPortal item,
            MutagenFrame frame)
        {
            item.Origin = Mutagen.Bethesda.Binary.FormLinkBinaryTranslation.Instance.Parse(
                frame: frame,
                defaultVal: FormKey.Null);
            item.Destination = Mutagen.Bethesda.Binary.FormLinkBinaryTranslation.Instance.Parse(
                frame: frame,
                defaultVal: FormKey.Null);
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class PortalBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IPortalGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PortalBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class PortalBinaryOverlay :
        BinaryOverlay,
        IPortalGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Portal_Registration.Instance;
        public static Portal_Registration Registration => Portal_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PortalCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PortalSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPortalGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IPortalGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IPortalGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public IEnumerable<FormLinkInformation> ContainedFormLinks => PortalCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => PortalBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((PortalBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public FormLink<IPlacedObjectGetter> Origin => new FormLink<IPlacedObjectGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(0x0, 0x4))));
        public FormLink<IPlacedObjectGetter> Destination => new FormLink<IPlacedObjectGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(0x4, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected PortalBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static PortalBinaryOverlay PortalFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new PortalBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x8),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x8;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static PortalBinaryOverlay PortalFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return PortalFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PortalMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IPortalGetter rhs)) return false;
            return ((PortalCommon)((IPortalGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IPortalGetter? obj)
        {
            return ((PortalCommon)((IPortalGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((PortalCommon)((IPortalGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

