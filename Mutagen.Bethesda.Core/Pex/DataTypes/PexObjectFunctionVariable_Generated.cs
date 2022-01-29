/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Pex.Internals;
using Noggog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Pex
{
    #region Class
    public partial class PexObjectFunctionVariable :
        IEquatable<IPexObjectFunctionVariableGetter>,
        ILoquiObjectSetter<PexObjectFunctionVariable>,
        IPexObjectFunctionVariable
    {
        #region Ctor
        public PexObjectFunctionVariable()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Name
        public String? Name { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        String? IPexObjectFunctionVariableGetter.Name => this.Name;
        #endregion
        #region TypeName
        public String? TypeName { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        String? IPexObjectFunctionVariableGetter.TypeName => this.TypeName;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            PexObjectFunctionVariableMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPexObjectFunctionVariableGetter rhs) return false;
            return ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IPexObjectFunctionVariableGetter? obj)
        {
            return ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Name = initialValue;
                this.TypeName = initialValue;
            }

            public Mask(
                TItem Name,
                TItem TypeName)
            {
                this.Name = Name;
                this.TypeName = TypeName;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Name;
            public TItem TypeName;
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
                if (!object.Equals(this.Name, rhs.Name)) return false;
                if (!object.Equals(this.TypeName, rhs.TypeName)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Name);
                hash.Add(this.TypeName);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Name)) return false;
                if (!eval(this.TypeName)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Name)) return true;
                if (eval(this.TypeName)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PexObjectFunctionVariable.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Name = eval(this.Name);
                obj.TypeName = eval(this.TypeName);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(PexObjectFunctionVariable.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, PexObjectFunctionVariable.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(PexObjectFunctionVariable.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Name ?? true)
                    {
                        fg.AppendItem(Name, "Name");
                    }
                    if (printMask?.TypeName ?? true)
                    {
                        fg.AppendItem(TypeName, "TypeName");
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
            public Exception? Name;
            public Exception? TypeName;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                PexObjectFunctionVariable_FieldIndex enu = (PexObjectFunctionVariable_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectFunctionVariable_FieldIndex.Name:
                        return Name;
                    case PexObjectFunctionVariable_FieldIndex.TypeName:
                        return TypeName;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                PexObjectFunctionVariable_FieldIndex enu = (PexObjectFunctionVariable_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectFunctionVariable_FieldIndex.Name:
                        this.Name = ex;
                        break;
                    case PexObjectFunctionVariable_FieldIndex.TypeName:
                        this.TypeName = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                PexObjectFunctionVariable_FieldIndex enu = (PexObjectFunctionVariable_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectFunctionVariable_FieldIndex.Name:
                        this.Name = (Exception?)obj;
                        break;
                    case PexObjectFunctionVariable_FieldIndex.TypeName:
                        this.TypeName = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Name != null) return true;
                if (TypeName != null) return true;
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
                fg.AppendItem(Name, "Name");
                fg.AppendItem(TypeName, "TypeName");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Name = this.Name.Combine(rhs.Name);
                ret.TypeName = this.TypeName.Combine(rhs.TypeName);
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
            public bool Name;
            public bool TypeName;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Name = defaultOn;
                this.TypeName = defaultOn;
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
                ret.Add((Name, null));
                ret.Add((TypeName, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((PexObjectFunctionVariableSetterCommon)((IPexObjectFunctionVariableGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static PexObjectFunctionVariable GetNew()
        {
            return new PexObjectFunctionVariable();
        }

    }
    #endregion

    #region Interface
    public partial interface IPexObjectFunctionVariable :
        ILoquiObjectSetter<IPexObjectFunctionVariable>,
        IPexObjectFunctionVariableGetter
    {
        new String? Name { get; set; }
        new String? TypeName { get; set; }
    }

    public partial interface IPexObjectFunctionVariableGetter :
        ILoquiObject,
        ILoquiObject<IPexObjectFunctionVariableGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => PexObjectFunctionVariable_Registration.Instance;
        String? Name { get; }
        String? TypeName { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PexObjectFunctionVariableMixIn
    {
        public static void Clear(this IPexObjectFunctionVariable item)
        {
            ((PexObjectFunctionVariableSetterCommon)((IPexObjectFunctionVariableGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PexObjectFunctionVariable.Mask<bool> GetEqualsMask(
            this IPexObjectFunctionVariableGetter item,
            IPexObjectFunctionVariableGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IPexObjectFunctionVariableGetter item,
            string? name = null,
            PexObjectFunctionVariable.Mask<bool>? printMask = null)
        {
            return ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IPexObjectFunctionVariableGetter item,
            FileGeneration fg,
            string? name = null,
            PexObjectFunctionVariable.Mask<bool>? printMask = null)
        {
            ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPexObjectFunctionVariableGetter item,
            IPexObjectFunctionVariableGetter rhs,
            PexObjectFunctionVariable.TranslationMask? equalsMask = null)
        {
            return ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionVariable lhs,
            IPexObjectFunctionVariableGetter rhs)
        {
            ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionVariable lhs,
            IPexObjectFunctionVariableGetter rhs,
            PexObjectFunctionVariable.TranslationMask? copyMask = null)
        {
            ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionVariable lhs,
            IPexObjectFunctionVariableGetter rhs,
            out PexObjectFunctionVariable.ErrorMask errorMask,
            PexObjectFunctionVariable.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PexObjectFunctionVariable.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPexObjectFunctionVariable lhs,
            IPexObjectFunctionVariableGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PexObjectFunctionVariable DeepCopy(
            this IPexObjectFunctionVariableGetter item,
            PexObjectFunctionVariable.TranslationMask? copyMask = null)
        {
            return ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PexObjectFunctionVariable DeepCopy(
            this IPexObjectFunctionVariableGetter item,
            out PexObjectFunctionVariable.ErrorMask errorMask,
            PexObjectFunctionVariable.TranslationMask? copyMask = null)
        {
            return ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PexObjectFunctionVariable DeepCopy(
            this IPexObjectFunctionVariableGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

    }
    #endregion

}

namespace Mutagen.Bethesda.Pex.Internals
{
    #region Field Index
    public enum PexObjectFunctionVariable_FieldIndex
    {
        Name = 0,
        TypeName = 1,
    }
    #endregion

    #region Registration
    public partial class PexObjectFunctionVariable_Registration : ILoquiRegistration
    {
        public static readonly PexObjectFunctionVariable_Registration Instance = new PexObjectFunctionVariable_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Pex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Pex.ProtocolKey,
            msgID: 15,
            version: 0);

        public const string GUID = "eadd25a2-cd64-4da0-95d0-9fdf432ee9aa";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(PexObjectFunctionVariable.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PexObjectFunctionVariable.ErrorMask);

        public static readonly Type ClassType = typeof(PexObjectFunctionVariable);

        public static readonly Type GetterType = typeof(IPexObjectFunctionVariableGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPexObjectFunctionVariable);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Pex.PexObjectFunctionVariable";

        public const string Name = "PexObjectFunctionVariable";

        public const string Namespace = "Mutagen.Bethesda.Pex";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

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
    public partial class PexObjectFunctionVariableSetterCommon
    {
        public static readonly PexObjectFunctionVariableSetterCommon Instance = new PexObjectFunctionVariableSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPexObjectFunctionVariable item)
        {
            ClearPartial();
            item.Name = default;
            item.TypeName = default;
        }
        
    }
    public partial class PexObjectFunctionVariableCommon
    {
        public static readonly PexObjectFunctionVariableCommon Instance = new PexObjectFunctionVariableCommon();

        public PexObjectFunctionVariable.Mask<bool> GetEqualsMask(
            IPexObjectFunctionVariableGetter item,
            IPexObjectFunctionVariableGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PexObjectFunctionVariable.Mask<bool>(false);
            ((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPexObjectFunctionVariableGetter item,
            IPexObjectFunctionVariableGetter rhs,
            PexObjectFunctionVariable.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Name = string.Equals(item.Name, rhs.Name);
            ret.TypeName = string.Equals(item.TypeName, rhs.TypeName);
        }
        
        public string ToString(
            IPexObjectFunctionVariableGetter item,
            string? name = null,
            PexObjectFunctionVariable.Mask<bool>? printMask = null)
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
            IPexObjectFunctionVariableGetter item,
            FileGeneration fg,
            string? name = null,
            PexObjectFunctionVariable.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"PexObjectFunctionVariable =>");
            }
            else
            {
                fg.AppendLine($"{name} (PexObjectFunctionVariable) =>");
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
            IPexObjectFunctionVariableGetter item,
            FileGeneration fg,
            PexObjectFunctionVariable.Mask<bool>? printMask = null)
        {
            if ((printMask?.Name ?? true)
                && item.Name is {} NameItem)
            {
                fg.AppendItem(NameItem, "Name");
            }
            if ((printMask?.TypeName ?? true)
                && item.TypeName is {} TypeNameItem)
            {
                fg.AppendItem(TypeNameItem, "TypeName");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPexObjectFunctionVariableGetter? lhs,
            IPexObjectFunctionVariableGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)PexObjectFunctionVariable_FieldIndex.Name) ?? true))
            {
                if (!string.Equals(lhs.Name, rhs.Name)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)PexObjectFunctionVariable_FieldIndex.TypeName) ?? true))
            {
                if (!string.Equals(lhs.TypeName, rhs.TypeName)) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IPexObjectFunctionVariableGetter item)
        {
            var hash = new HashCode();
            if (item.Name is {} Nameitem)
            {
                hash.Add(Nameitem);
            }
            if (item.TypeName is {} TypeNameitem)
            {
                hash.Add(TypeNameitem);
            }
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return PexObjectFunctionVariable.GetNew();
        }
        
    }
    public partial class PexObjectFunctionVariableSetterTranslationCommon
    {
        public static readonly PexObjectFunctionVariableSetterTranslationCommon Instance = new PexObjectFunctionVariableSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPexObjectFunctionVariable item,
            IPexObjectFunctionVariableGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)PexObjectFunctionVariable_FieldIndex.Name) ?? true))
            {
                item.Name = rhs.Name;
            }
            if ((copyMask?.GetShouldTranslate((int)PexObjectFunctionVariable_FieldIndex.TypeName) ?? true))
            {
                item.TypeName = rhs.TypeName;
            }
        }
        
        #endregion
        
        public PexObjectFunctionVariable DeepCopy(
            IPexObjectFunctionVariableGetter item,
            PexObjectFunctionVariable.TranslationMask? copyMask = null)
        {
            PexObjectFunctionVariable ret = (PexObjectFunctionVariable)((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).GetNew();
            ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PexObjectFunctionVariable DeepCopy(
            IPexObjectFunctionVariableGetter item,
            out PexObjectFunctionVariable.ErrorMask errorMask,
            PexObjectFunctionVariable.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PexObjectFunctionVariable ret = (PexObjectFunctionVariable)((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).GetNew();
            ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PexObjectFunctionVariable.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PexObjectFunctionVariable DeepCopy(
            IPexObjectFunctionVariableGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PexObjectFunctionVariable ret = (PexObjectFunctionVariable)((PexObjectFunctionVariableCommon)((IPexObjectFunctionVariableGetter)item).CommonInstance()!).GetNew();
            ((PexObjectFunctionVariableSetterTranslationCommon)((IPexObjectFunctionVariableGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Pex
{
    public partial class PexObjectFunctionVariable
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PexObjectFunctionVariable_Registration.Instance;
        public static PexObjectFunctionVariable_Registration StaticRegistration => PexObjectFunctionVariable_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PexObjectFunctionVariableCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return PexObjectFunctionVariableSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PexObjectFunctionVariableSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPexObjectFunctionVariableGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IPexObjectFunctionVariableGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IPexObjectFunctionVariableGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

