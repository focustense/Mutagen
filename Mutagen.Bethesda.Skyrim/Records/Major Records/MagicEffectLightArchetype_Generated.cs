/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class MagicEffectLightArchetype :
        MagicEffectArchetype,
        IEquatable<IMagicEffectLightArchetypeGetter>,
        ILoquiObjectSetter<MagicEffectLightArchetype>,
        IMagicEffectLightArchetypeInternal
    {

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectLightArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectLightArchetypeGetter rhs) return false;
            return ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IMagicEffectLightArchetypeGetter? obj)
        {
            return ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            MagicEffectArchetype.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }

            public Mask(
                TItem Type,
                TItem AssociationKey,
                TItem ActorValue)
            : base(
                Type: Type,
                AssociationKey: AssociationKey,
                ActorValue: ActorValue)
            {
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

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
                if (!base.Equals(rhs)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new MagicEffectLightArchetype.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(MagicEffectLightArchetype.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, MagicEffectLightArchetype.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(MagicEffectLightArchetype.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            MagicEffectArchetype.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                MagicEffectLightArchetype_FieldIndex enu = (MagicEffectLightArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                MagicEffectLightArchetype_FieldIndex enu = (MagicEffectLightArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                MagicEffectLightArchetype_FieldIndex enu = (MagicEffectLightArchetype_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            MagicEffectArchetype.TranslationMask,
            ITranslationMask
        {
            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectLightArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((MagicEffectLightArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static MagicEffectLightArchetype CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new MagicEffectLightArchetype();
            ((MagicEffectLightArchetypeSetterCommon)((IMagicEffectLightArchetypeGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out MagicEffectLightArchetype item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((MagicEffectLightArchetypeSetterCommon)((IMagicEffectLightArchetypeGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new MagicEffectLightArchetype GetNew()
        {
            return new MagicEffectLightArchetype();
        }

    }
    #endregion

    #region Interface
    public partial interface IMagicEffectLightArchetype :
        ILoquiObjectSetter<IMagicEffectLightArchetypeInternal>,
        IMagicEffectArchetypeInternal,
        IMagicEffectLightArchetypeGetter
    {
    }

    public partial interface IMagicEffectLightArchetypeInternal :
        IMagicEffectArchetypeInternal,
        IMagicEffectLightArchetype,
        IMagicEffectLightArchetypeGetter
    {
    }

    public partial interface IMagicEffectLightArchetypeGetter :
        IMagicEffectArchetypeGetter,
        IBinaryItem,
        ILoquiObject<IMagicEffectLightArchetypeGetter>
    {
        static new ILoquiRegistration StaticRegistration => MagicEffectLightArchetype_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class MagicEffectLightArchetypeMixIn
    {
        public static void Clear(this IMagicEffectLightArchetypeInternal item)
        {
            ((MagicEffectLightArchetypeSetterCommon)((IMagicEffectLightArchetypeGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static MagicEffectLightArchetype.Mask<bool> GetEqualsMask(
            this IMagicEffectLightArchetypeGetter item,
            IMagicEffectLightArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IMagicEffectLightArchetypeGetter item,
            string? name = null,
            MagicEffectLightArchetype.Mask<bool>? printMask = null)
        {
            return ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IMagicEffectLightArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectLightArchetype.Mask<bool>? printMask = null)
        {
            ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IMagicEffectLightArchetypeGetter item,
            IMagicEffectLightArchetypeGetter rhs,
            MagicEffectLightArchetype.TranslationMask? equalsMask = null)
        {
            return ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IMagicEffectLightArchetypeInternal lhs,
            IMagicEffectLightArchetypeGetter rhs,
            out MagicEffectLightArchetype.ErrorMask errorMask,
            MagicEffectLightArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = MagicEffectLightArchetype.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IMagicEffectLightArchetypeInternal lhs,
            IMagicEffectLightArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static MagicEffectLightArchetype DeepCopy(
            this IMagicEffectLightArchetypeGetter item,
            MagicEffectLightArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static MagicEffectLightArchetype DeepCopy(
            this IMagicEffectLightArchetypeGetter item,
            out MagicEffectLightArchetype.ErrorMask errorMask,
            MagicEffectLightArchetype.TranslationMask? copyMask = null)
        {
            return ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static MagicEffectLightArchetype DeepCopy(
            this IMagicEffectLightArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IMagicEffectLightArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((MagicEffectLightArchetypeSetterCommon)((IMagicEffectLightArchetypeGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum MagicEffectLightArchetype_FieldIndex
    {
        Type = 0,
        AssociationKey = 1,
        ActorValue = 2,
    }
    #endregion

    #region Registration
    internal partial class MagicEffectLightArchetype_Registration : ILoquiRegistration
    {
        public static readonly MagicEffectLightArchetype_Registration Instance = new MagicEffectLightArchetype_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 110,
            version: 0);

        public const string GUID = "6705b341-5add-4696-8844-027e4134ad64";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(MagicEffectLightArchetype.Mask<>);

        public static readonly Type ErrorMaskType = typeof(MagicEffectLightArchetype.ErrorMask);

        public static readonly Type ClassType = typeof(MagicEffectLightArchetype);

        public static readonly Type GetterType = typeof(IMagicEffectLightArchetypeGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IMagicEffectLightArchetype);

        public static readonly Type? InternalSetterType = typeof(IMagicEffectLightArchetypeInternal);

        public const string FullName = "Mutagen.Bethesda.Skyrim.MagicEffectLightArchetype";

        public const string Name = "MagicEffectLightArchetype";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(MagicEffectLightArchetypeBinaryWriteTranslation);
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
    internal partial class MagicEffectLightArchetypeSetterCommon : MagicEffectArchetypeSetterCommon
    {
        public new static readonly MagicEffectLightArchetypeSetterCommon Instance = new MagicEffectLightArchetypeSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IMagicEffectLightArchetypeInternal item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IMagicEffectArchetypeInternal item)
        {
            Clear(item: (IMagicEffectLightArchetypeInternal)item);
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IMagicEffectLightArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: MagicEffectLightArchetypeBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IMagicEffectArchetypeInternal item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (MagicEffectLightArchetype)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class MagicEffectLightArchetypeCommon : MagicEffectArchetypeCommon
    {
        public new static readonly MagicEffectLightArchetypeCommon Instance = new MagicEffectLightArchetypeCommon();

        public MagicEffectLightArchetype.Mask<bool> GetEqualsMask(
            IMagicEffectLightArchetypeGetter item,
            IMagicEffectLightArchetypeGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new MagicEffectLightArchetype.Mask<bool>(false);
            ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IMagicEffectLightArchetypeGetter item,
            IMagicEffectLightArchetypeGetter rhs,
            MagicEffectLightArchetype.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IMagicEffectLightArchetypeGetter item,
            string? name = null,
            MagicEffectLightArchetype.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IMagicEffectLightArchetypeGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            MagicEffectLightArchetype.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"MagicEffectLightArchetype =>");
            }
            else
            {
                sb.AppendLine($"{name} (MagicEffectLightArchetype) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IMagicEffectLightArchetypeGetter item,
            StructuredStringBuilder sb,
            MagicEffectLightArchetype.Mask<bool>? printMask = null)
        {
            MagicEffectArchetypeCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static MagicEffectLightArchetype_FieldIndex ConvertFieldIndex(MagicEffectArchetype_FieldIndex index)
        {
            switch (index)
            {
                case MagicEffectArchetype_FieldIndex.Type:
                    return (MagicEffectLightArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.AssociationKey:
                    return (MagicEffectLightArchetype_FieldIndex)((int)index);
                case MagicEffectArchetype_FieldIndex.ActorValue:
                    return (MagicEffectLightArchetype_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IMagicEffectLightArchetypeGetter? lhs,
            IMagicEffectLightArchetypeGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IMagicEffectArchetypeGetter)lhs, (IMagicEffectArchetypeGetter)rhs, crystal)) return false;
            return true;
        }
        
        public override bool Equals(
            IMagicEffectArchetypeGetter? lhs,
            IMagicEffectArchetypeGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IMagicEffectLightArchetypeGetter?)lhs,
                rhs: rhs as IMagicEffectLightArchetypeGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IMagicEffectLightArchetypeGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IMagicEffectArchetypeGetter item)
        {
            return GetHashCode(item: (IMagicEffectLightArchetypeGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return MagicEffectLightArchetype.GetNew();
        }
        
<<<<<<< HEAD
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IMagicEffectLightArchetypeGetter obj)
        {
            yield break;
        }
        
        #endregion
        
=======
>>>>>>> nog-assets
    }
    internal partial class MagicEffectLightArchetypeSetterTranslationCommon : MagicEffectArchetypeSetterTranslationCommon
    {
        public new static readonly MagicEffectLightArchetypeSetterTranslationCommon Instance = new MagicEffectLightArchetypeSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IMagicEffectLightArchetypeInternal item,
            IMagicEffectLightArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                item,
                rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public void DeepCopyIn(
            IMagicEffectLightArchetype item,
            IMagicEffectLightArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IMagicEffectArchetype)item,
                (IMagicEffectArchetypeGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetypeInternal item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectLightArchetypeInternal)item,
                rhs: (IMagicEffectLightArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        public override void DeepCopyIn(
            IMagicEffectArchetype item,
            IMagicEffectArchetypeGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IMagicEffectLightArchetype)item,
                rhs: (IMagicEffectLightArchetypeGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public MagicEffectLightArchetype DeepCopy(
            IMagicEffectLightArchetypeGetter item,
            MagicEffectLightArchetype.TranslationMask? copyMask = null)
        {
            MagicEffectLightArchetype ret = (MagicEffectLightArchetype)((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public MagicEffectLightArchetype DeepCopy(
            IMagicEffectLightArchetypeGetter item,
            out MagicEffectLightArchetype.ErrorMask errorMask,
            MagicEffectLightArchetype.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            MagicEffectLightArchetype ret = (MagicEffectLightArchetype)((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = MagicEffectLightArchetype.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public MagicEffectLightArchetype DeepCopy(
            IMagicEffectLightArchetypeGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            MagicEffectLightArchetype ret = (MagicEffectLightArchetype)((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)item).CommonInstance()!).GetNew();
            ((MagicEffectLightArchetypeSetterTranslationCommon)((IMagicEffectLightArchetypeGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class MagicEffectLightArchetype
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectLightArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectLightArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectLightArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return MagicEffectLightArchetypeSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectLightArchetypeSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class MagicEffectLightArchetypeBinaryWriteTranslation :
        MagicEffectArchetypeBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly MagicEffectLightArchetypeBinaryWriteTranslation Instance = new();

        public void Write(
            MutagenWriter writer,
            IMagicEffectLightArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            MagicEffectArchetypeBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IMagicEffectLightArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IMagicEffectArchetypeGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IMagicEffectLightArchetypeGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class MagicEffectLightArchetypeBinaryCreateTranslation : MagicEffectArchetypeBinaryCreateTranslation
    {
        public new static readonly MagicEffectLightArchetypeBinaryCreateTranslation Instance = new MagicEffectLightArchetypeBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class MagicEffectLightArchetypeBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class MagicEffectLightArchetypeBinaryOverlay :
        MagicEffectArchetypeBinaryOverlay,
        IMagicEffectLightArchetypeGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => MagicEffectLightArchetype_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => MagicEffectLightArchetype_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => MagicEffectLightArchetypeCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => MagicEffectLightArchetypeSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => MagicEffectLightArchetypeBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((MagicEffectLightArchetypeBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected MagicEffectLightArchetypeBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IMagicEffectLightArchetypeGetter MagicEffectLightArchetypeFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new MagicEffectLightArchetypeBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IMagicEffectLightArchetypeGetter MagicEffectLightArchetypeFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return MagicEffectLightArchetypeFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            MagicEffectLightArchetypeMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IMagicEffectLightArchetypeGetter rhs) return false;
            return ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IMagicEffectLightArchetypeGetter? obj)
        {
            return ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((MagicEffectLightArchetypeCommon)((IMagicEffectLightArchetypeGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

