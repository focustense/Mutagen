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
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
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
    public partial class BookSkill :
        BookTeachTarget,
        IBookSkill,
        IEquatable<IBookSkillGetter>,
        ILoquiObjectSetter<BookSkill>
    {
        #region Ctor
        public BookSkill()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Skill
        public Skill? Skill { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        Skill? IBookSkillGetter.Skill => this.Skill;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            BookSkillMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBookSkillGetter rhs) return false;
            return ((BookSkillCommon)((IBookSkillGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IBookSkillGetter? obj)
        {
            return ((BookSkillCommon)((IBookSkillGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((BookSkillCommon)((IBookSkillGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            BookTeachTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Skill)
            : base()
            {
                this.Skill = Skill;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Skill;
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
                if (!object.Equals(this.Skill, rhs.Skill)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Skill);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Skill)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Skill)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new BookSkill.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Skill = eval(this.Skill);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(BookSkill.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, BookSkill.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(BookSkill.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Skill ?? true)
                    {
                        fg.AppendItem(Skill, "Skill");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            BookTeachTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Skill;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                BookSkill_FieldIndex enu = (BookSkill_FieldIndex)index;
                switch (enu)
                {
                    case BookSkill_FieldIndex.Skill:
                        return Skill;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                BookSkill_FieldIndex enu = (BookSkill_FieldIndex)index;
                switch (enu)
                {
                    case BookSkill_FieldIndex.Skill:
                        this.Skill = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                BookSkill_FieldIndex enu = (BookSkill_FieldIndex)index;
                switch (enu)
                {
                    case BookSkill_FieldIndex.Skill:
                        this.Skill = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Skill != null) return true;
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

            public override void ToString(FileGeneration fg, string? name = null)
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
            protected override void ToString_FillInternal(FileGeneration fg)
            {
                base.ToString_FillInternal(fg);
                fg.AppendItem(Skill, "Skill");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Skill = this.Skill.Combine(rhs.Skill);
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
            BookTeachTarget.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Skill;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Skill = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Skill, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => BookSkillBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((BookSkillBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static BookSkill CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new BookSkill();
            ((BookSkillSetterCommon)((IBookSkillGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out BookSkill item,
            TypedParseParams? translationParams = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((BookSkillSetterCommon)((IBookSkillGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new BookSkill GetNew()
        {
            return new BookSkill();
        }

    }
    #endregion

    #region Interface
    public partial interface IBookSkill :
        IBookSkillGetter,
        IBookTeachTarget,
        ILoquiObjectSetter<IBookSkill>
    {
        new Skill? Skill { get; set; }
    }

    public partial interface IBookSkillGetter :
        IBookTeachTargetGetter,
        IBinaryItem,
        ILoquiObject<IBookSkillGetter>
    {
        static new ILoquiRegistration StaticRegistration => BookSkill_Registration.Instance;
        Skill? Skill { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class BookSkillMixIn
    {
        public static void Clear(this IBookSkill item)
        {
            ((BookSkillSetterCommon)((IBookSkillGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static BookSkill.Mask<bool> GetEqualsMask(
            this IBookSkillGetter item,
            IBookSkillGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IBookSkillGetter item,
            string? name = null,
            BookSkill.Mask<bool>? printMask = null)
        {
            return ((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IBookSkillGetter item,
            FileGeneration fg,
            string? name = null,
            BookSkill.Mask<bool>? printMask = null)
        {
            ((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IBookSkillGetter item,
            IBookSkillGetter rhs,
            BookSkill.TranslationMask? equalsMask = null)
        {
            return ((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IBookSkill lhs,
            IBookSkillGetter rhs,
            out BookSkill.ErrorMask errorMask,
            BookSkill.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((BookSkillSetterTranslationCommon)((IBookSkillGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = BookSkill.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IBookSkill lhs,
            IBookSkillGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((BookSkillSetterTranslationCommon)((IBookSkillGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static BookSkill DeepCopy(
            this IBookSkillGetter item,
            BookSkill.TranslationMask? copyMask = null)
        {
            return ((BookSkillSetterTranslationCommon)((IBookSkillGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static BookSkill DeepCopy(
            this IBookSkillGetter item,
            out BookSkill.ErrorMask errorMask,
            BookSkill.TranslationMask? copyMask = null)
        {
            return ((BookSkillSetterTranslationCommon)((IBookSkillGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static BookSkill DeepCopy(
            this IBookSkillGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((BookSkillSetterTranslationCommon)((IBookSkillGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IBookSkill item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((BookSkillSetterCommon)((IBookSkillGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum BookSkill_FieldIndex
    {
        Skill = 0,
    }
    #endregion

    #region Registration
    public partial class BookSkill_Registration : ILoquiRegistration
    {
        public static readonly BookSkill_Registration Instance = new BookSkill_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 157,
            version: 0);

        public const string GUID = "4b9c1ac7-82ca-47b8-af25-dae58cb74d14";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(BookSkill.Mask<>);

        public static readonly Type ErrorMaskType = typeof(BookSkill.ErrorMask);

        public static readonly Type ClassType = typeof(BookSkill);

        public static readonly Type GetterType = typeof(IBookSkillGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IBookSkill);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.BookSkill";

        public const string Name = "BookSkill";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(BookSkillBinaryWriteTranslation);
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
    public partial class BookSkillSetterCommon : BookTeachTargetSetterCommon
    {
        public new static readonly BookSkillSetterCommon Instance = new BookSkillSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IBookSkill item)
        {
            ClearPartial();
            item.Skill = default;
            base.Clear(item);
        }
        
        public override void Clear(IBookTeachTarget item)
        {
            Clear(item: (IBookSkill)item);
        }
        
        #region Mutagen
        public void RemapLinks(IBookSkill obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IBookSkill item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: BookSkillBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IBookTeachTarget item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            CopyInFromBinary(
                item: (BookSkill)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    public partial class BookSkillCommon : BookTeachTargetCommon
    {
        public new static readonly BookSkillCommon Instance = new BookSkillCommon();

        public BookSkill.Mask<bool> GetEqualsMask(
            IBookSkillGetter item,
            IBookSkillGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new BookSkill.Mask<bool>(false);
            ((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IBookSkillGetter item,
            IBookSkillGetter rhs,
            BookSkill.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Skill = item.Skill == rhs.Skill;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IBookSkillGetter item,
            string? name = null,
            BookSkill.Mask<bool>? printMask = null)
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
            IBookSkillGetter item,
            FileGeneration fg,
            string? name = null,
            BookSkill.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"BookSkill =>");
            }
            else
            {
                fg.AppendLine($"{name} (BookSkill) =>");
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
            IBookSkillGetter item,
            FileGeneration fg,
            BookSkill.Mask<bool>? printMask = null)
        {
            BookTeachTargetCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if ((printMask?.Skill ?? true)
                && item.Skill is {} SkillItem)
            {
                fg.AppendItem(SkillItem, "Skill");
            }
        }
        
        public static BookSkill_FieldIndex ConvertFieldIndex(BookTeachTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IBookSkillGetter? lhs,
            IBookSkillGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IBookTeachTargetGetter)lhs, (IBookTeachTargetGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)BookSkill_FieldIndex.Skill) ?? true))
            {
                if (lhs.Skill != rhs.Skill) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IBookTeachTargetGetter? lhs,
            IBookTeachTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IBookSkillGetter?)lhs,
                rhs: rhs as IBookSkillGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IBookSkillGetter item)
        {
            var hash = new HashCode();
            if (item.Skill is {} Skillitem)
            {
                hash.Add(Skillitem);
            }
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IBookTeachTargetGetter item)
        {
            return GetHashCode(item: (IBookSkillGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return BookSkill.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> GetContainedFormLinks(IBookSkillGetter obj)
        {
            foreach (var item in base.GetContainedFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    public partial class BookSkillSetterTranslationCommon : BookTeachTargetSetterTranslationCommon
    {
        public new static readonly BookSkillSetterTranslationCommon Instance = new BookSkillSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IBookSkill item,
            IBookSkillGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IBookTeachTarget)item,
                (IBookTeachTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)BookSkill_FieldIndex.Skill) ?? true))
            {
                item.Skill = rhs.Skill;
            }
        }
        
        
        public override void DeepCopyIn(
            IBookTeachTarget item,
            IBookTeachTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IBookSkill)item,
                rhs: (IBookSkillGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public BookSkill DeepCopy(
            IBookSkillGetter item,
            BookSkill.TranslationMask? copyMask = null)
        {
            BookSkill ret = (BookSkill)((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).GetNew();
            ((BookSkillSetterTranslationCommon)((IBookSkillGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public BookSkill DeepCopy(
            IBookSkillGetter item,
            out BookSkill.ErrorMask errorMask,
            BookSkill.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            BookSkill ret = (BookSkill)((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).GetNew();
            ((BookSkillSetterTranslationCommon)((IBookSkillGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = BookSkill.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public BookSkill DeepCopy(
            IBookSkillGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            BookSkill ret = (BookSkill)((BookSkillCommon)((IBookSkillGetter)item).CommonInstance()!).GetNew();
            ((BookSkillSetterTranslationCommon)((IBookSkillGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class BookSkill
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookSkill_Registration.Instance;
        public new static BookSkill_Registration StaticRegistration => BookSkill_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => BookSkillCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return BookSkillSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => BookSkillSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class BookSkillBinaryWriteTranslation :
        BookTeachTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static BookSkillBinaryWriteTranslation Instance = new BookSkillBinaryWriteTranslation();

        public static void WriteEmbedded(
            IBookSkillGetter item,
            MutagenWriter writer)
        {
            EnumBinaryTranslation<Skill, MutagenFrame, MutagenWriter>.Instance.Write(
                writer,
                ((int?)item.Skill) ?? -1,
                length: 4);
        }

        public void Write(
            MutagenWriter writer,
            IBookSkillGetter item,
            TypedWriteParams? translationParams = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IBookSkillGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IBookTeachTargetGetter item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IBookSkillGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    public partial class BookSkillBinaryCreateTranslation : BookTeachTargetBinaryCreateTranslation
    {
        public new readonly static BookSkillBinaryCreateTranslation Instance = new BookSkillBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IBookSkill item,
            MutagenFrame frame)
        {
            if (frame.Complete) return;
            item.Skill = EnumBinaryTranslation<Skill, MutagenFrame, MutagenWriter>.Instance.Parse(
                reader: frame,
                length: 4);
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class BookSkillBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class BookSkillBinaryOverlay :
        BookTeachTargetBinaryOverlay,
        IBookSkillGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookSkill_Registration.Instance;
        public new static BookSkill_Registration StaticRegistration => BookSkill_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => BookSkillCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => BookSkillSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => BookSkillBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((BookSkillBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        #region Skill
        public Skill? Skill
        {
            get
            {
                var val = (Skill)BinaryPrimitives.ReadInt32LittleEndian(_data.Span.Slice(0x0, 0x4));
                if (((int)val) == -1) return null;
                return val;
            }
        }
        #endregion
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected BookSkillBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static BookSkillBinaryOverlay BookSkillFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new BookSkillBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x4),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static BookSkillBinaryOverlay BookSkillFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return BookSkillFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            BookSkillMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBookSkillGetter rhs) return false;
            return ((BookSkillCommon)((IBookSkillGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IBookSkillGetter? obj)
        {
            return ((BookSkillCommon)((IBookSkillGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((BookSkillCommon)((IBookSkillGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

