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
using Mutagen.Bethesda.Records;
using Mutagen.Bethesda.Records.Binary.Overlay;
using Mutagen.Bethesda.Records.Binary.Streams;
using Mutagen.Bethesda.Records.Binary.Translations;
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
    /// <summary>
    /// Implemented by: [LocationTarget, LocationCell, LocationObjectId, LocationObjectType, LocationKeyword, LocationFallback]
    /// </summary>
    public abstract partial class ALocationTarget :
        IALocationTarget,
        IEquatable<IALocationTargetGetter>,
        ILoquiObjectSetter<ALocationTarget>
    {
        #region Ctor
        public ALocationTarget()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ALocationTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IALocationTargetGetter rhs) return false;
            return ((ALocationTargetCommon)((IALocationTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IALocationTargetGetter? obj)
        {
            return ((ALocationTargetCommon)((IALocationTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ALocationTargetCommon)((IALocationTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public virtual bool All(Func<TItem, bool> eval)
            {
                return true;
            }
            #endregion

            #region Any
            public virtual bool Any(Func<TItem, bool> eval)
            {
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ALocationTarget.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(ALocationTarget.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, ALocationTarget.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(ALocationTarget.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
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
            #endregion

            #region IErrorMask
            public virtual object? GetNthMask(int index)
            {
                ALocationTarget_FieldIndex enu = (ALocationTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                ALocationTarget_FieldIndex enu = (ALocationTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                ALocationTarget_FieldIndex enu = (ALocationTarget_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual bool IsInError()
            {
                if (Overall != null) return true;
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

            public virtual void ToString(FileGeneration fg, string? name = null)
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
            protected virtual void ToString_FillInternal(FileGeneration fg)
            {
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
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
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

            protected virtual void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public virtual IEnumerable<FormLinkInformation> ContainedFormLinks => ALocationTargetCommon.Instance.GetContainedFormLinks(this);
        public virtual void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => ALocationTargetSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ALocationTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ALocationTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((ALocationTargetSetterCommon)((IALocationTargetGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static ALocationTarget GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [LocationTarget, LocationCell, LocationObjectId, LocationObjectType, LocationKeyword, LocationFallback]
    /// </summary>
    public partial interface IALocationTarget :
        IALocationTargetGetter,
        IFormLinkContainer,
        ILoquiObjectSetter<IALocationTarget>
    {
    }

    /// <summary>
    /// Implemented by: [LocationTarget, LocationCell, LocationObjectId, LocationObjectType, LocationKeyword, LocationFallback]
    /// </summary>
    public partial interface IALocationTargetGetter :
        ILoquiObject,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IALocationTargetGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => ALocationTarget_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class ALocationTargetMixIn
    {
        public static void Clear(this IALocationTarget item)
        {
            ((ALocationTargetSetterCommon)((IALocationTargetGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ALocationTarget.Mask<bool> GetEqualsMask(
            this IALocationTargetGetter item,
            IALocationTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IALocationTargetGetter item,
            string? name = null,
            ALocationTarget.Mask<bool>? printMask = null)
        {
            return ((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IALocationTargetGetter item,
            FileGeneration fg,
            string? name = null,
            ALocationTarget.Mask<bool>? printMask = null)
        {
            ((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IALocationTargetGetter item,
            IALocationTargetGetter rhs,
            ALocationTarget.TranslationMask? equalsMask = null)
        {
            return ((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IALocationTarget lhs,
            IALocationTargetGetter rhs)
        {
            ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IALocationTarget lhs,
            IALocationTargetGetter rhs,
            ALocationTarget.TranslationMask? copyMask = null)
        {
            ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IALocationTarget lhs,
            IALocationTargetGetter rhs,
            out ALocationTarget.ErrorMask errorMask,
            ALocationTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ALocationTarget.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IALocationTarget lhs,
            IALocationTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ALocationTarget DeepCopy(
            this IALocationTargetGetter item,
            ALocationTarget.TranslationMask? copyMask = null)
        {
            return ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ALocationTarget DeepCopy(
            this IALocationTargetGetter item,
            out ALocationTarget.ErrorMask errorMask,
            ALocationTarget.TranslationMask? copyMask = null)
        {
            return ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ALocationTarget DeepCopy(
            this IALocationTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IALocationTarget item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ALocationTargetSetterCommon)((IALocationTargetGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    public enum ALocationTarget_FieldIndex
    {
    }
    #endregion

    #region Registration
    public partial class ALocationTarget_Registration : ILoquiRegistration
    {
        public static readonly ALocationTarget_Registration Instance = new ALocationTarget_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 222,
            version: 0);

        public const string GUID = "9dbd900f-2e31-46bb-a927-ac5831e0c2ec";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(ALocationTarget.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ALocationTarget.ErrorMask);

        public static readonly Type ClassType = typeof(ALocationTarget);

        public static readonly Type GetterType = typeof(IALocationTargetGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IALocationTarget);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.ALocationTarget";

        public const string Name = "ALocationTarget";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ALocationTargetBinaryWriteTranslation);
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
    public partial class ALocationTargetSetterCommon
    {
        public static readonly ALocationTargetSetterCommon Instance = new ALocationTargetSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IALocationTarget item)
        {
            ClearPartial();
        }
        
        #region Mutagen
        public void RemapLinks(IALocationTarget obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IALocationTarget item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }
        
        #endregion
        
    }
    public partial class ALocationTargetCommon
    {
        public static readonly ALocationTargetCommon Instance = new ALocationTargetCommon();

        public ALocationTarget.Mask<bool> GetEqualsMask(
            IALocationTargetGetter item,
            IALocationTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ALocationTarget.Mask<bool>(false);
            ((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IALocationTargetGetter item,
            IALocationTargetGetter rhs,
            ALocationTarget.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
        }
        
        public string ToString(
            IALocationTargetGetter item,
            string? name = null,
            ALocationTarget.Mask<bool>? printMask = null)
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
            IALocationTargetGetter item,
            FileGeneration fg,
            string? name = null,
            ALocationTarget.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"ALocationTarget =>");
            }
            else
            {
                fg.AppendLine($"{name} (ALocationTarget) =>");
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
            IALocationTargetGetter item,
            FileGeneration fg,
            ALocationTarget.Mask<bool>? printMask = null)
        {
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IALocationTargetGetter? lhs,
            IALocationTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            return true;
        }
        
        public virtual int GetHashCode(IALocationTargetGetter item)
        {
            var hash = new HashCode();
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return ALocationTarget.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetContainedFormLinks(IALocationTargetGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    public partial class ALocationTargetSetterTranslationCommon
    {
        public static readonly ALocationTargetSetterTranslationCommon Instance = new ALocationTargetSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IALocationTarget item,
            IALocationTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
        }
        
        #endregion
        
        public ALocationTarget DeepCopy(
            IALocationTargetGetter item,
            ALocationTarget.TranslationMask? copyMask = null)
        {
            ALocationTarget ret = (ALocationTarget)((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).GetNew();
            ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ALocationTarget DeepCopy(
            IALocationTargetGetter item,
            out ALocationTarget.ErrorMask errorMask,
            ALocationTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ALocationTarget ret = (ALocationTarget)((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).GetNew();
            ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ALocationTarget.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ALocationTarget DeepCopy(
            IALocationTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ALocationTarget ret = (ALocationTarget)((ALocationTargetCommon)((IALocationTargetGetter)item).CommonInstance()!).GetNew();
            ((ALocationTargetSetterTranslationCommon)((IALocationTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ALocationTarget
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ALocationTarget_Registration.Instance;
        public static ALocationTarget_Registration Registration => ALocationTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ALocationTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return ALocationTargetSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ALocationTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IALocationTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IALocationTargetGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IALocationTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ALocationTargetBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static ALocationTargetBinaryWriteTranslation Instance = new ALocationTargetBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IALocationTargetGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IALocationTargetGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class ALocationTargetBinaryCreateTranslation
    {
        public readonly static ALocationTargetBinaryCreateTranslation Instance = new ALocationTargetBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ALocationTargetBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IALocationTargetGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ALocationTargetBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ALocationTargetBinaryOverlay :
        PluginBinaryOverlay,
        IALocationTargetGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ALocationTarget_Registration.Instance;
        public static ALocationTarget_Registration Registration => ALocationTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ALocationTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ALocationTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IALocationTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IALocationTargetGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IALocationTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        public virtual IEnumerable<FormLinkInformation> ContainedFormLinks => ALocationTargetCommon.Instance.GetContainedFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ALocationTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ALocationTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ALocationTargetBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public virtual void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ALocationTargetMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IALocationTargetGetter rhs) return false;
            return ((ALocationTargetCommon)((IALocationTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IALocationTargetGetter? obj)
        {
            return ((ALocationTargetCommon)((IALocationTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ALocationTargetCommon)((IALocationTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

