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
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Meta;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Starfield.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Starfield.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Starfield.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Starfield
{
    #region Class
    public partial class NoteVoice :
        ANoteData,
        IEquatable<INoteVoiceGetter>,
        ILoquiObjectSetter<NoteVoice>,
        INoteVoice
    {
        #region Ctor
        public NoteVoice()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Scene
        private readonly IFormLinkNullable<ISceneGetter> _Scene = new FormLinkNullable<ISceneGetter>();
        public IFormLinkNullable<ISceneGetter> Scene
        {
            get => _Scene;
            set => _Scene.SetTo(value);
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkNullableGetter<ISceneGetter> INoteVoiceGetter.Scene => this.Scene;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            NoteVoiceMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not INoteVoiceGetter rhs) return false;
            return ((NoteVoiceCommon)((INoteVoiceGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(INoteVoiceGetter? obj)
        {
            return ((NoteVoiceCommon)((INoteVoiceGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((NoteVoiceCommon)((INoteVoiceGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ANoteData.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Scene)
            : base()
            {
                this.Scene = Scene;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Scene;
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
                if (!object.Equals(this.Scene, rhs.Scene)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Scene);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Scene)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Scene)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new NoteVoice.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Scene = eval(this.Scene);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(NoteVoice.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, NoteVoice.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(NoteVoice.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Scene ?? true)
                    {
                        sb.AppendItem(Scene, "Scene");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            ANoteData.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Scene;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                NoteVoice_FieldIndex enu = (NoteVoice_FieldIndex)index;
                switch (enu)
                {
                    case NoteVoice_FieldIndex.Scene:
                        return Scene;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                NoteVoice_FieldIndex enu = (NoteVoice_FieldIndex)index;
                switch (enu)
                {
                    case NoteVoice_FieldIndex.Scene:
                        this.Scene = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                NoteVoice_FieldIndex enu = (NoteVoice_FieldIndex)index;
                switch (enu)
                {
                    case NoteVoice_FieldIndex.Scene:
                        this.Scene = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Scene != null) return true;
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
                {
                    sb.AppendItem(Scene, "Scene");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Scene = this.Scene.Combine(rhs.Scene);
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
            ANoteData.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Scene;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Scene = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Scene, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => NoteVoiceCommon.Instance.EnumerateFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => NoteVoiceSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => NoteVoiceBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((NoteVoiceBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static NoteVoice CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new NoteVoice();
            ((NoteVoiceSetterCommon)((INoteVoiceGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out NoteVoice item,
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
            ((NoteVoiceSetterCommon)((INoteVoiceGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new NoteVoice GetNew()
        {
            return new NoteVoice();
        }

    }
    #endregion

    #region Interface
    public partial interface INoteVoice :
        IANoteData,
        IFormLinkContainer,
        ILoquiObjectSetter<INoteVoice>,
        INoteVoiceGetter
    {
        new IFormLinkNullable<ISceneGetter> Scene { get; set; }
    }

    public partial interface INoteVoiceGetter :
        IANoteDataGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<INoteVoiceGetter>
    {
        static new ILoquiRegistration StaticRegistration => NoteVoice_Registration.Instance;
        IFormLinkNullableGetter<ISceneGetter> Scene { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class NoteVoiceMixIn
    {
        public static void Clear(this INoteVoice item)
        {
            ((NoteVoiceSetterCommon)((INoteVoiceGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static NoteVoice.Mask<bool> GetEqualsMask(
            this INoteVoiceGetter item,
            INoteVoiceGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this INoteVoiceGetter item,
            string? name = null,
            NoteVoice.Mask<bool>? printMask = null)
        {
            return ((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this INoteVoiceGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            NoteVoice.Mask<bool>? printMask = null)
        {
            ((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this INoteVoiceGetter item,
            INoteVoiceGetter rhs,
            NoteVoice.TranslationMask? equalsMask = null)
        {
            return ((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this INoteVoice lhs,
            INoteVoiceGetter rhs,
            out NoteVoice.ErrorMask errorMask,
            NoteVoice.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = NoteVoice.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this INoteVoice lhs,
            INoteVoiceGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static NoteVoice DeepCopy(
            this INoteVoiceGetter item,
            NoteVoice.TranslationMask? copyMask = null)
        {
            return ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static NoteVoice DeepCopy(
            this INoteVoiceGetter item,
            out NoteVoice.ErrorMask errorMask,
            NoteVoice.TranslationMask? copyMask = null)
        {
            return ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static NoteVoice DeepCopy(
            this INoteVoiceGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this INoteVoice item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((NoteVoiceSetterCommon)((INoteVoiceGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Starfield
{
    #region Field Index
    internal enum NoteVoice_FieldIndex
    {
        Scene = 0,
    }
    #endregion

    #region Registration
    internal partial class NoteVoice_Registration : ILoquiRegistration
    {
        public static readonly NoteVoice_Registration Instance = new NoteVoice_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Starfield.ProtocolKey;

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(NoteVoice.Mask<>);

        public static readonly Type ErrorMaskType = typeof(NoteVoice.ErrorMask);

        public static readonly Type ClassType = typeof(NoteVoice);

        public static readonly Type GetterType = typeof(INoteVoiceGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(INoteVoice);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Starfield.NoteVoice";

        public const string Name = "NoteVoice";

        public const string Namespace = "Mutagen.Bethesda.Starfield";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(NoteVoiceBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
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
    internal partial class NoteVoiceSetterCommon : ANoteDataSetterCommon
    {
        public new static readonly NoteVoiceSetterCommon Instance = new NoteVoiceSetterCommon();

        partial void ClearPartial();
        
        public void Clear(INoteVoice item)
        {
            ClearPartial();
            item.Scene.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IANoteData item)
        {
            Clear(item: (INoteVoice)item);
        }
        
        #region Mutagen
        public void RemapLinks(INoteVoice obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Scene.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            INoteVoice item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: NoteVoiceBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IANoteData item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (NoteVoice)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class NoteVoiceCommon : ANoteDataCommon
    {
        public new static readonly NoteVoiceCommon Instance = new NoteVoiceCommon();

        public NoteVoice.Mask<bool> GetEqualsMask(
            INoteVoiceGetter item,
            INoteVoiceGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new NoteVoice.Mask<bool>(false);
            ((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            INoteVoiceGetter item,
            INoteVoiceGetter rhs,
            NoteVoice.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Scene = item.Scene.Equals(rhs.Scene);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            INoteVoiceGetter item,
            string? name = null,
            NoteVoice.Mask<bool>? printMask = null)
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
            INoteVoiceGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            NoteVoice.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"NoteVoice =>");
            }
            else
            {
                sb.AppendLine($"{name} (NoteVoice) =>");
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
            INoteVoiceGetter item,
            StructuredStringBuilder sb,
            NoteVoice.Mask<bool>? printMask = null)
        {
            ANoteDataCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Scene ?? true)
            {
                sb.AppendItem(item.Scene.FormKeyNullable, "Scene");
            }
        }
        
        public static NoteVoice_FieldIndex ConvertFieldIndex(ANoteData_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            INoteVoiceGetter? lhs,
            INoteVoiceGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IANoteDataGetter)lhs, (IANoteDataGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)NoteVoice_FieldIndex.Scene) ?? true))
            {
                if (!lhs.Scene.Equals(rhs.Scene)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IANoteDataGetter? lhs,
            IANoteDataGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (INoteVoiceGetter?)lhs,
                rhs: rhs as INoteVoiceGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(INoteVoiceGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Scene);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IANoteDataGetter item)
        {
            return GetHashCode(item: (INoteVoiceGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return NoteVoice.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(INoteVoiceGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            if (FormLinkInformation.TryFactory(obj.Scene, out var SceneInfo))
            {
                yield return SceneInfo;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class NoteVoiceSetterTranslationCommon : ANoteDataSetterTranslationCommon
    {
        public new static readonly NoteVoiceSetterTranslationCommon Instance = new NoteVoiceSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            INoteVoice item,
            INoteVoiceGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IANoteData)item,
                (IANoteDataGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)NoteVoice_FieldIndex.Scene) ?? true))
            {
                item.Scene.SetTo(rhs.Scene.FormKeyNullable);
            }
        }
        
        
        public override void DeepCopyIn(
            IANoteData item,
            IANoteDataGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (INoteVoice)item,
                rhs: (INoteVoiceGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public NoteVoice DeepCopy(
            INoteVoiceGetter item,
            NoteVoice.TranslationMask? copyMask = null)
        {
            NoteVoice ret = (NoteVoice)((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).GetNew();
            ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public NoteVoice DeepCopy(
            INoteVoiceGetter item,
            out NoteVoice.ErrorMask errorMask,
            NoteVoice.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            NoteVoice ret = (NoteVoice)((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).GetNew();
            ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = NoteVoice.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public NoteVoice DeepCopy(
            INoteVoiceGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            NoteVoice ret = (NoteVoice)((NoteVoiceCommon)((INoteVoiceGetter)item).CommonInstance()!).GetNew();
            ((NoteVoiceSetterTranslationCommon)((INoteVoiceGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Starfield
{
    public partial class NoteVoice
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => NoteVoice_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => NoteVoice_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => NoteVoiceCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return NoteVoiceSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => NoteVoiceSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Starfield
{
    public partial class NoteVoiceBinaryWriteTranslation :
        ANoteDataBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly NoteVoiceBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            INoteVoiceGetter item,
            MutagenWriter writer)
        {
            FormLinkBinaryTranslation.Instance.WriteNullable(
                writer: writer,
                item: item.Scene);
        }

        public void Write(
            MutagenWriter writer,
            INoteVoiceGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (INoteVoiceGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IANoteDataGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (INoteVoiceGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class NoteVoiceBinaryCreateTranslation : ANoteDataBinaryCreateTranslation
    {
        public new static readonly NoteVoiceBinaryCreateTranslation Instance = new NoteVoiceBinaryCreateTranslation();

        public static void FillBinaryStructs(
            INoteVoice item,
            MutagenFrame frame)
        {
            if (frame.Complete) return;
            item.Scene.SetTo(FormLinkBinaryTranslation.Instance.Parse(reader: frame));
        }

    }

}
namespace Mutagen.Bethesda.Starfield
{
    #region Binary Write Mixins
    public static class NoteVoiceBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Starfield
{
    internal partial class NoteVoiceBinaryOverlay :
        ANoteDataBinaryOverlay,
        INoteVoiceGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => NoteVoice_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => NoteVoice_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => NoteVoiceCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => NoteVoiceSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => NoteVoiceCommon.Instance.EnumerateFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => NoteVoiceBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((NoteVoiceBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public IFormLinkNullableGetter<ISceneGetter> Scene => FormLinkBinaryTranslation.Instance.NullableOverlayFactory<ISceneGetter>(_package, _structData.Span.Slice(0x0, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected NoteVoiceBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static INoteVoiceGetter NoteVoiceFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x4,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new NoteVoiceBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static INoteVoiceGetter NoteVoiceFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return NoteVoiceFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            NoteVoiceMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not INoteVoiceGetter rhs) return false;
            return ((NoteVoiceCommon)((INoteVoiceGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(INoteVoiceGetter? obj)
        {
            return ((NoteVoiceCommon)((INoteVoiceGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((NoteVoiceCommon)((INoteVoiceGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

