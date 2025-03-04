using Loqui.Generation;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;
using Noggog;
using Mutagen.Bethesda.Generation.Fields;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using DictType = Mutagen.Bethesda.Generation.Fields.DictType;
using ObjectType = Mutagen.Bethesda.Plugins.Meta.ObjectType;

namespace Mutagen.Bethesda.Generation.Modules.Plugin;

public class MajorRecordRemovalModule : GenerationModule
{
    class InterfInstr
    {
        public string Interf;
    }

    public override async Task GenerateInClass(ObjectGeneration obj, StructuredStringBuilder sb)
    {
        if (await MajorRecordModule.HasMajorRecordsInTree(obj, false) == Case.No) return;
        GenerateClassImplementation(obj, sb);
    }

    public static void GenerateClassImplementation(ObjectGeneration obj, StructuredStringBuilder sb, bool onlyGetter = false)
    {
        if (!onlyGetter)
        {
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove({nameof(FormKey)} formKey) => this.Remove(formKey);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove(HashSet<{nameof(FormKey)}> formKeys) => this.Remove(formKeys);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove(IEnumerable<{nameof(FormKey)}> formKeys) => this.Remove(formKeys);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove(IEnumerable<{nameof(IFormLinkIdentifier)}> formLinks) => this.Remove(formLinks);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove({nameof(FormKey)} formKey, Type type, bool throwIfUnknown) => this.Remove(formKey, type, throwIfUnknown);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove(HashSet<{nameof(FormKey)}> formKeys, Type type, bool throwIfUnknown) => this.Remove(formKeys, type, throwIfUnknown);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove(IEnumerable<{nameof(FormKey)}> formKeys, Type type, bool throwIfUnknown) => this.Remove(formKeys, type, throwIfUnknown);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove<TMajor>({nameof(FormKey)} formKey, bool throwIfUnknown) => this.Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}(formKey, throwIfUnknown);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove<TMajor>(HashSet<{nameof(FormKey)}> formKeys, bool throwIfUnknown) => this.Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}(formKeys, throwIfUnknown);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove<TMajor>(IEnumerable<{nameof(FormKey)}> formKeys, bool throwIfUnknown) => this.Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}(formKeys, throwIfUnknown);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove<TMajor>(TMajor record, bool throwIfUnknown) => this.Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}(record, throwIfUnknown);");
            sb.AppendLine("[DebuggerStepThrough]");
            sb.AppendLine($"void {nameof(IMajorRecordEnumerable)}.Remove<TMajor>(IEnumerable<TMajor> records, bool throwIfUnknown) => this.Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}(records, throwIfUnknown);");
        }
    }

    public override async Task GenerateInCommonMixin(ObjectGeneration obj, StructuredStringBuilder sb)
    {
        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal)}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"{nameof(FormKey)} key");
        }
        using (sb.CurlyBrace())
        {
            sb.AppendLine($"var keys = new HashSet<{nameof(FormKey)}>();");
            sb.AppendLine("keys.Add(key);");
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.AddPassArg("keys");
            }
        }
        sb.AppendLine();

        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal)}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"IEnumerable<{nameof(FormKey)}> keys");
        }
        using (sb.CurlyBrace())
        {
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.Add("keys: keys.ToHashSet()");
            }
        }
        sb.AppendLine();
        
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal)}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"IEnumerable<{nameof(IFormLinkIdentifier)}> keys");
        }
        using (sb.CurlyBrace())
        {
            sb.AppendLine("foreach (var g in keys.GroupBy(x => x.Type))");
            using (sb.CurlyBrace())
            {
                using (var c = sb.Call("Remove"))
                {
                    c.AddPassArg("obj");
                    c.Add("keys: g.Select(x => x.FormKey)");
                    c.Add("type: g.Key");
                }
            }
        }
        sb.AppendLine();

        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal)}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"HashSet<{nameof(FormKey)}> keys");
        }
        using (sb.CurlyBrace())
        {
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.AddPassArg("keys");
            }
        }
        sb.AppendLine();

        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal)}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"{nameof(FormKey)} key");
            args.Add($"{nameof(Type)} type");
            args.Add($"bool throwIfUnknown = true");
        }
        using (sb.CurlyBrace())
        {
            sb.AppendLine($"var keys = new HashSet<{nameof(FormKey)}>();");
            sb.AppendLine("keys.Add(key);");
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.AddPassArg("keys");
                args.AddPassArg("type");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();

        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal)}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"IEnumerable<{nameof(FormKey)}> keys");
            args.Add($"{nameof(Type)} type");
            args.Add($"bool throwIfUnknown = true");
        }
        using (sb.CurlyBrace())
        {
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.Add("keys: keys.ToHashSet()");
                args.AddPassArg("type");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();

        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal)}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"HashSet<{nameof(FormKey)}> keys");
            args.Add($"{nameof(Type)} type");
            args.Add($"bool throwIfUnknown = true");
        }
        using (sb.CurlyBrace())
        {
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.AddPassArg("keys");
                args.AddPassArg("type");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();

        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"TMajor record");
            args.Add($"bool throwIfUnknown = true");
            args.Wheres.Add($"where TMajor : {nameof(IMajorRecordGetter)}");
        }
        using (sb.CurlyBrace())
        {
            sb.AppendLine($"var keys = new HashSet<{nameof(FormKey)}>();");
            sb.AppendLine("keys.Add(record.FormKey);");
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.AddPassArg("keys");
                args.Add("type: typeof(TMajor)");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();

        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"IEnumerable<TMajor> records");
            args.Add($"bool throwIfUnknown = true");
            args.Wheres.Add($"where TMajor : {nameof(IMajorRecordGetter)}");
        }
        using (sb.CurlyBrace())
        {
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.Add("keys: records.Select(m => m.FormKey).ToHashSet()");
                args.Add("type: typeof(TMajor)");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();

        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"{nameof(FormKey)} key");
            args.Add($"bool throwIfUnknown = true");
            args.Wheres.Add($"where TMajor : {nameof(IMajorRecordGetter)}");
        }
        using (sb.CurlyBrace())
        {
            sb.AppendLine($"var keys = new HashSet<{nameof(FormKey)}>();");
            sb.AppendLine("keys.Add(key);");
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.AddPassArg("keys");
                args.Add("type: typeof(TMajor)");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();

        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"IEnumerable<{nameof(FormKey)}> keys");
            args.Add($"bool throwIfUnknown = true");
            args.Wheres.Add($"where TMajor : {nameof(IMajorRecordGetter)}");
        }
        using (sb.CurlyBrace())
        {
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.Add("keys: keys.ToHashSet()");
                args.Add("type: typeof(TMajor)");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();

        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        sb.AppendLine("[DebuggerStepThrough]");
        using (var args = sb.Function(
                   $"public static void Remove{obj.GetGenericTypes(MaskType.Normal, "TMajor")}"))
        {
            args.Wheres.AddRange(obj.GenerateWhereClauses(LoquiInterfaceType.ISetter, obj.Generics));
            args.Add($"this {obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"HashSet<{nameof(FormKey)}> keys");
            args.Add($"bool throwIfUnknown = true");
            args.Wheres.Add($"where TMajor : {nameof(IMajorRecordGetter)}");
        }
        using (sb.CurlyBrace())
        {
            using (var args = sb.Call(
                       $"{obj.CommonClassInstance("obj", LoquiInterfaceType.ISetter, CommonGenerics.Class)}.Remove"))
            {
                args.AddPassArg("obj");
                args.AddPassArg("keys");
                args.Add("type: typeof(TMajor)");
                args.AddPassArg("throwIfUnknown");
            }
        }
        sb.AppendLine();
    }

    public override async Task GenerateInCommon(ObjectGeneration obj, StructuredStringBuilder sb, MaskTypeSet maskTypes)
    {
        if (!maskTypes.Applicable(LoquiInterfaceType.ISetter, CommonGenerics.Class)) return;
        var accessor = new Accessor("obj");
        if (await MajorRecordModule.HasMajorRecordsInTree(obj, includeBaseClass: false) == Case.No) return;
        var overrideStr = await obj.FunctionOverride(async c => await MajorRecordModule.HasMajorRecords(c, includeBaseClass: false, includeSelf: true) != Case.No);

        using (var args = sb.Function(
                   $"public{overrideStr}void Remove"))
        {
            args.Add($"{obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"HashSet<{nameof(FormKey)}> keys");
        }
        using (sb.CurlyBrace())
        {
            var sbCount = sb.Count;
            foreach (var baseClass in obj.BaseClassTrail())
            {
                if (await MajorRecordModule.HasMajorRecords(baseClass, includeBaseClass: true, includeSelf: true) != Case.No)
                {
                    sb.AppendLine($"base.Remove(obj, keys);");
                    break;
                }
            }
            foreach (var field in obj.IterateFields())
            {
                switch (field)
                {
                    case LoquiType _:
                    case ContainerType _:
                    case DictType _:
                        break;
                    default:
                        continue;
                }

                StructuredStringBuilder fieldFg = new StructuredStringBuilder();

                if (field is LoquiType loqui)
                {
                    var fieldAccessor = $"{accessor}.{loqui.Name}";
                    if (await MajorRecordModule.HasMajorRecords(loqui.TargetObjectGeneration, includeBaseClass: true, includeSelf: false) != Case.No)
                    {
                        sb.AppendLine($"{fieldAccessor}{loqui.NullChar}.Remove(keys);");
                    }
                    var isMajorRecord = loqui.TargetObjectGeneration != null && await loqui.TargetObjectGeneration.IsMajorRecord();
                    if (isMajorRecord)
                    {
                        sb.AppendLine($"if ({(loqui.Nullable ? $"{fieldAccessor} != null && " : string.Empty)}keys.Contains({fieldAccessor}.FormKey))");
                        using (sb.CurlyBrace())
                        {
                            sb.AppendLine($"{fieldAccessor} = null;");
                        }
                    }
                }
                else if (field is ContainerType cont)
                {
                    if (!(cont.SubTypeGeneration is LoquiType contLoqui)) continue;
                    var isMajorRecord = await contLoqui.IsMajorRecord();
                    if (isMajorRecord)
                    {
                        sb.AppendLine($"{accessor}.{field.Name}.Remove(keys);");
                    }
                    if (await MajorRecordModule.HasMajorRecords(contLoqui, includeBaseClass: true, includeSelf: false) != Case.No)
                    {
                        sb.AppendLine($"{accessor}.{field.Name}.ForEach(i => i.Remove(keys));");
                    }
                    if (contLoqui.TargetObjectGeneration?.IsListGroup() ?? false)
                    {
                        sb.AppendLine($"{accessor}.{field.Name}.RemoveWhere(i => i.{contLoqui.TargetObjectGeneration.Fields.FirstOrDefault(f => f is ContainerType).Name}.Count == 0);");
                    }
                }
                else if (field is DictType dict)
                {
                    if (dict.Mode != DictMode.KeyedValue) continue;
                    if (!(dict.ValueTypeGen is LoquiType dictLoqui)) continue;
                    var isMajorRecord = dictLoqui.TargetObjectGeneration != null && await dictLoqui.TargetObjectGeneration.IsMajorRecord();
                    if (isMajorRecord
                        || await MajorRecordModule.HasMajorRecords(dictLoqui, includeBaseClass: true) != Case.No)
                    {
                        switch (await MajorRecordModule.HasMajorRecords(dictLoqui, includeBaseClass: true))
                        {
                            case Case.Yes:
                            case Case.Maybe:
                                sb.AppendLine($"{accessor}.{field.Name}.Remove(keys);");
                                break;
                            case Case.No:
                            default:
                                break;
                        }
                    }
                }

                if (fieldFg.Count > 0)
                {
                    if (field.Nullable)
                    {
                        sb.AppendLine($"if ({field.NullableAccessor(getter: true, Accessor.FromType(field, accessor.ToString()))})");
                    }
                    using (sb.CurlyBrace(doIt: field.Nullable))
                    {
                        sb.AppendLines(fieldFg);
                    }
                }
            }
        }
        sb.AppendLine();

        // Generate base overrides  
        foreach (var baseClass in obj.BaseClassTrail())
        {
            if (await MajorRecordModule.HasMajorRecords(baseClass, includeBaseClass: true, includeSelf: true) != Case.No)
            {
                using (var args = sb.Function(
                           $"public override void Remove"))
                {
                    args.Add($"{baseClass.Interface(getter: false)} obj");
                    args.Add($"HashSet<{nameof(FormKey)}> keys");
                }
                using (sb.CurlyBrace())
                {
                    using (var args = sb.Call(
                               "Remove"))
                    {
                        args.Add($"({obj.Interface(getter: false)})obj");
                        args.AddPassArg("keys");
                    }
                }
                sb.AppendLine();
            }
        }

        using (var args = sb.Function(
                   $"public{overrideStr}void Remove"))
        {
            args.Add($"{obj.Interface(getter: false, internalInterface: true)} obj");
            args.Add($"HashSet<{nameof(FormKey)}> keys");
            args.Add($"Type type");
            args.Add($"bool throwIfUnknown");
        }
        using (sb.CurlyBrace())
        {
            var sbCount = sb.Count;
            foreach (var baseClass in obj.BaseClassTrail())
            {
                if (await MajorRecordModule.HasMajorRecords(baseClass, includeBaseClass: true, includeSelf: true) != Case.No)
                {
                    sb.AppendLine("base.Remove(obj, type, keys);");
                    break;
                }
            }

            sb.AppendLine("switch (type.Name)");
            using (sb.CurlyBrace())
            {
                var gameCategory = obj.GetObjectData().GameCategory;
                sb.AppendLine($"case \"{nameof(IMajorRecord)}\":");
                sb.AppendLine($"case \"{nameof(MajorRecord)}\":");
                if (gameCategory != null)
                {
                    sb.AppendLine($"case \"I{gameCategory}MajorRecord\":");
                    sb.AppendLine($"case \"{gameCategory}MajorRecord\":");
                }
                sb.AppendLine($"case \"{nameof(IMajorRecordGetter)}\":");
                if (gameCategory != null)
                {
                    sb.AppendLine($"case \"I{gameCategory}MajorRecordGetter\":");
                }
                using (sb.IncreaseDepth())
                {
                    sb.AppendLine($"if (!{obj.RegistrationName}.SetterType.IsAssignableFrom(obj.GetType())) return;");
                    sb.AppendLine("this.Remove(obj, keys);");
                    sb.AppendLine("break;");
                }

                Dictionary<object, StructuredStringBuilder> generationDict = new Dictionary<object, StructuredStringBuilder>();
                foreach (var field in obj.IterateFields())
                {
                    LoquiType targetLoqui;
                    StructuredStringBuilder fieldGen;
                    if (field is LoquiType loqui)
                    {
                        if (loqui.TargetObjectGeneration.IsListGroup()) continue;
                        var isMajorRecord = loqui.TargetObjectGeneration != null && await loqui.TargetObjectGeneration.IsMajorRecord();
                        if (!isMajorRecord
                            && await MajorRecordModule.HasMajorRecords(loqui, includeBaseClass: true) == Case.No)
                        {
                            continue;
                        }

                        if (loqui.TargetObjectGeneration.GetObjectType() == ObjectType.Group)
                        {
                            fieldGen = generationDict.GetOrAdd(loqui.GetGroupTarget());
                        }
                        else
                        {
                            fieldGen = generationDict.GetOrAdd(((object)loqui?.TargetObjectGeneration) ?? loqui);
                        }
                        targetLoqui = loqui;
                    }
                    else if (field is ContainerType cont)
                    {
                        if (!(cont.SubTypeGeneration is LoquiType contLoqui)) continue;
                        if (contLoqui.RefType == LoquiType.LoquiRefType.Generic)
                        {
                            fieldGen = generationDict.GetOrAdd("default:");
                        }
                        else
                        {
                            fieldGen = generationDict.GetOrAdd(((object)contLoqui?.TargetObjectGeneration) ?? contLoqui);
                        }
                        targetLoqui = contLoqui;
                    }
                    else if (field is DictType dict)
                    {
                        if (dict.Mode != DictMode.KeyedValue) continue;
                        if (!(dict.ValueTypeGen is LoquiType dictLoqui)) continue;
                        if (dictLoqui.RefType == LoquiType.LoquiRefType.Generic)
                        {
                            fieldGen = generationDict.GetOrAdd("default:");
                        }
                        else
                        {
                            fieldGen = generationDict.GetOrAdd(((object)dictLoqui?.TargetObjectGeneration) ?? dictLoqui);
                        }
                        targetLoqui = dictLoqui;
                    }
                    else
                    {
                        continue;
                    }
                    bool applicable = false;
                    switch (targetLoqui.RefType)
                    {
                        case LoquiType.LoquiRefType.Direct:
                            applicable = await targetLoqui.TargetObjectGeneration.IsMajorRecord();
                            break;
                        case LoquiType.LoquiRefType.Interface:
                            applicable = true;
                            break;
                        case LoquiType.LoquiRefType.Generic:
                        default:
                            break;
                    }
                    await ApplyRemovalLines(field, fieldGen, accessor, removeSelf: applicable);
                }

                bool doAdditionlDeepLogic = !obj.Name.EndsWith("ListGroup");

                if (doAdditionlDeepLogic)
                {
                    LinkInterfaceModule.ObjectMappings.TryGetValue(obj.ProtoGen.Protocol, out var interfs);

                    var deepRecordMapping = await MajorRecordModule.FindDeepRecords(obj);
                    foreach (var deepRec in deepRecordMapping)
                    {
                        StructuredStringBuilder deepFg = generationDict.GetOrAdd(deepRec.Key);
                        foreach (var field in deepRec.Value)
                        {
                            var remSelf = false;
                            switch (field)
                            {
                                case ContainerType cont:
                                    if (cont.SubTypeGeneration is LoquiType loqui)
                                    {
                                        switch (loqui.RefType)
                                        {
                                            case LoquiType.LoquiRefType.Direct:
                                                remSelf = loqui.TargetObjectGeneration == deepRec.Key;
                                                break;
                                            case LoquiType.LoquiRefType.Interface:
                                                if (interfs.TryGetValue(loqui.SetterInterface, out var objs))
                                                {
                                                    remSelf = objs.Contains(deepRec.Key);
                                                }
                                                break;
                                            case LoquiType.LoquiRefType.Generic:
                                            default:
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                            remSelf &= await deepRec.Key.IsMajorRecord();
                            await ApplyRemovalLines(field, deepFg, accessor, obj: deepRec.Key, removeSelf: remSelf);
                        }
                    }

                    // Generate for major record marker interfaces 
                    foreach (var interf in interfs.EmptyIfNull())
                    {
                        StructuredStringBuilder subFg = new StructuredStringBuilder();
                        HashSet<ObjectGeneration> passedObjects = new HashSet<ObjectGeneration>();
                        HashSet<TypeGeneration> deepObjects = new HashSet<TypeGeneration>();
                        foreach (var subObj in interf.Value)
                        {
                            var grup = obj.Fields
                                .WhereCastable<TypeGeneration, GroupType>()
                                .Where(g => g.GetGroupTarget() == subObj)
                                .FirstOrDefault();

                            if (grup != null)
                            {
                                subFg.AppendLine($"Remove({accessor}, keys, typeof({grup.GetGroupTarget().Interface(getter: true)}), throwIfUnknown: throwIfUnknown);");
                                passedObjects.Add(grup.GetGroupTarget());
                            }
                            else if (deepRecordMapping.TryGetValue(subObj, out var deepRec))
                            {
                                foreach (var field in deepRec)
                                {
                                    deepObjects.Add(field);
                                }
                            }
                        }
                        foreach (var deepObj in deepObjects)
                        {
                            bool remSelf = false;
                            switch (deepObj)
                            {
                                case ContainerType cont:
                                    if (cont.SubTypeGeneration is LoquiType loqui)
                                    {
                                        remSelf = loqui.RefType == LoquiType.LoquiRefType.Interface && loqui.Interface(getter: false) == interf.Key;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            await ApplyRemovalLines(deepObj, subFg, accessor, blackList: passedObjects, removeSelf: remSelf);
                        }
                        if (!subFg.Empty)
                        {
                            var genFg = generationDict.GetOrAdd(new InterfInstr()
                            {
                                Interf = interf.Key
                            });
                            genFg.AppendLines(subFg);
                        }
                    }

                    foreach (var kv in generationDict)
                    {
                        switch (kv.Key)
                        {
                            case LoquiType loqui:
                                if (loqui.RefType == LoquiType.LoquiRefType.Direct)
                                {
                                    sb.AppendLine($"case \"{loqui.Interface(getter: true)}\":");
                                    sb.AppendLine($"case \"{loqui.Interface(getter: false)}\":");
                                    if (loqui.HasInternalGetInterface)
                                    {
                                        sb.AppendLine($"case \"{loqui.Interface(getter: true, internalInterface: true)}\":");
                                    }
                                    if (loqui.HasInternalSetInterface)
                                    {
                                        sb.AppendLine($"case \"{loqui.Interface(getter: false, internalInterface: true)}\":");
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                                break;
                            case ObjectGeneration targetObj:
                                targetObj.AppendSwitchCases(sb);
                                if (targetObj.Abstract)
                                {
                                    foreach (var subObj in await targetObj.InheritingObjects())
                                    {
                                        subObj.AppendSwitchCases(sb);
                                    }
                                }
                                break;
                            case InterfInstr interf:
                                sb.AppendLine($"case \"{interf.Interf}\":");
                                sb.AppendLine($"case \"{interf.Interf}Getter\":");
                                break;
                            case string str:
                                if (str != "default:")
                                {
                                    throw new NotImplementedException();
                                }
                                continue;
                            default:
                                throw new NotImplementedException();
                        }
                        using (sb.IncreaseDepth())
                        {
                            sb.AppendLines(kv.Value);
                            sb.AppendLine("break;");
                        }
                    }
                }

                sb.AppendLine("default:");
                using (sb.IncreaseDepth())
                {
                    if (generationDict.TryGetValue("default:", out var gen))
                    {
                        sb.AppendLines(gen);
                        sb.AppendLine("break;");
                    }
                    else
                    {
                        sb.AppendLine("if (throwIfUnknown)");
                        using (sb.CurlyBrace())
                        {
                            sb.AppendLine("throw new ArgumentException($\"Unknown major record type: {type}\");");
                        }
                        sb.AppendLine($"else");
                        using (sb.CurlyBrace())
                        {
                            sb.AppendLine("break;");
                        }
                    }
                }
            }
        }
        sb.AppendLine();

        // Generate base overrides  
        foreach (var baseClass in obj.BaseClassTrail())
        {
            if (await MajorRecordModule.HasMajorRecords(baseClass, includeBaseClass: true, includeSelf: true) != Case.No)
            {
                using (var args = sb.Function(
                           $"public override void Remove"))
                {
                    args.Add($"{baseClass.Interface(getter: false)} obj");
                    args.Add($"HashSet<{nameof(FormKey)}> keys");
                    args.Add($"Type type");
                    args.Add($"bool throwIfUnknown");
                }
                using (sb.CurlyBrace())
                {
                    using (var args = sb.Call(
                               "Remove"))
                    {
                        args.Add($"({obj.Interface(getter: false)})obj");
                        args.AddPassArg("keys");
                        args.AddPassArg("type");
                        args.AddPassArg("throwIfUnknown");
                    }
                }
                sb.AppendLine();
            }
        }
    }

    async Task ApplyRemovalLines(
        TypeGeneration field,
        StructuredStringBuilder fieldGen,
        Accessor accessor,
        bool removeSelf,
        ObjectGeneration obj = null,
        HashSet<ObjectGeneration> blackList = null)
    {
        if (field is GroupType group)
        {
            if (blackList?.Contains(group.GetGroupTarget()) ?? false) return;
            using (var args = fieldGen.Call(
                       $"obj.{field.Name}.Remove"))
            {
                args.AddPassArg("type");
                args.AddPassArg("keys");
            }
        }
        else if (field is LoquiType loqui)
        {
            if (blackList?.Contains(loqui.TargetObjectGeneration) ?? false) return;
            var fieldAccessor = loqui.Nullable ? $"{obj?.ObjectName}{loqui.Name}item" : $"{accessor}.{loqui.Name}";
            if (loqui.TargetObjectGeneration.IsListGroup())
            { // List groups
                using (var args = fieldGen.Call(
                           $"obj.{field.Name}.Remove"))
                {
                    args.AddPassArg("type");
                    args.AddPassArg("keys");
                }
                return;
            }
            var subFg = new StructuredStringBuilder();
            subFg.AppendLine($"{fieldAccessor}.Remove(keys, type, throwIfUnknown);");
            if (loqui.Singleton
                || !loqui.Nullable)
            {
                fieldGen.AppendLines(subFg);
            }
            else
            {
                using (fieldGen.CurlyBrace())
                {
                    fieldGen.AppendLine($"if ({accessor}.{loqui.Name} is {{}} {fieldAccessor})");
                    using (fieldGen.CurlyBrace())
                    {
                        fieldGen.AppendLines(subFg);
                    }
                }
            }
        }
        else if (field is ContainerType cont)
        {
            if (cont.SubTypeGeneration is not LoquiType contLoqui) return;
            if (contLoqui.RefType == LoquiType.LoquiRefType.Generic)
            {
                fieldGen.AppendLine($"foreach (var item in obj.{field.Name})");
                using (fieldGen.CurlyBrace())
                {
                    fieldGen.AppendLine($"item.Remove(keys, type, throwIfUnknown: false);");
                }
                fieldGen.AppendLine($"obj.{field.Name}.RemoveWhere(i => i.{contLoqui.TargetObjectGeneration.Fields.FirstOrDefault(f => f is ContainerType).Name}.Count == 0);");
            }
            else
            {
                var isMajorRecord = contLoqui.TargetObjectGeneration != null && await contLoqui.TargetObjectGeneration.IsMajorRecord();
                if (isMajorRecord
                    || await MajorRecordModule.HasMajorRecords(contLoqui, includeBaseClass: true) != Case.No)
                {
                    if (removeSelf)
                    {
                        fieldGen.AppendLine($"obj.{field.Name}.RemoveWhere(i => keys.Contains(i.FormKey));");
                    }
                    switch (await MajorRecordModule.HasMajorRecords(contLoqui, includeBaseClass: true, includeSelf: false))
                    {
                        case Case.Yes:
                        case Case.Maybe:
                            fieldGen.AppendLine($"foreach (var subItem in {accessor}.{field.Name}{(field.Nullable ? ".EmptyIfNull()" : null)})");
                            using (fieldGen.CurlyBrace())
                            {
                                fieldGen.AppendLine("subItem.Remove(keys, type, throwIfUnknown: false);");
                            }
                            break;
                        case Case.No:
                        default:
                            break;
                    }
                }
            }
            if (contLoqui.TargetObjectGeneration != null
                && contLoqui.TargetObjectGeneration.IsListGroup()
                && (await contLoqui.TargetObjectGeneration.GetGroupLoquiType()).TargetObjectGeneration == obj)
            {
                fieldGen.AppendLine($"{accessor}.{field.Name}.RemoveWhere(i => i.{contLoqui.TargetObjectGeneration.Fields.FirstOrDefault(f => f is ContainerType).Name}.Count == 0);");
            }
        }
        else if (field is DictType dict)
        {
            if (dict.Mode != DictMode.KeyedValue) return;
            if (dict.ValueTypeGen is not LoquiType dictLoqui) return;
            if (dictLoqui.RefType == LoquiType.LoquiRefType.Generic)
            {
                fieldGen.AppendLine($"if (type.IsAssignableFrom(typeof({dictLoqui.GenericDef.Name})))");
                using (fieldGen.CurlyBrace())
                {
                    fieldGen.AppendLine($"obj.RecordCache.Remove(keys);");
                }
                fieldGen.AppendLine($"foreach (var item in obj.{field.Name}.Items)");
                using (fieldGen.CurlyBrace())
                {
                    fieldGen.AppendLine($"item.Remove(keys, type, throwIfUnknown: false);");
                }
            }
            else
            {
                var isMajorRecord = dictLoqui.TargetObjectGeneration != null && await dictLoqui.TargetObjectGeneration.IsMajorRecord();
                if (isMajorRecord
                    || await MajorRecordModule.HasMajorRecords(dictLoqui, includeBaseClass: true) != Case.No)
                {
                    switch (await MajorRecordModule.HasMajorRecords(dictLoqui, includeBaseClass: true))
                    {
                        case Case.Yes:
                            fieldGen.AppendLine($"foreach (var subItem in {accessor}.{field.Name}.Items)");
                            using (fieldGen.CurlyBrace())
                            {
                                throw new NotImplementedException();
                            }
                            break;
                        case Case.Maybe:
                            fieldGen.AppendLine($"foreach (var subItem in {accessor}.{field.Name}.Items.WhereCastable<{dictLoqui.TypeName(getter: false)}, {nameof(IMajorRecordEnumerable)}>())");
                            using (fieldGen.CurlyBrace())
                            {
                                throw new NotImplementedException();
                            }
                            break;
                        case Case.No:
                        default:
                            break;
                    }
                }
            }
        }
    }
}