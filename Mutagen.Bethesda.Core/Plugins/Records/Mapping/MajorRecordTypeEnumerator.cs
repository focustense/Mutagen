using System.Collections.Concurrent;
using Loqui;
using Noggog;
namespace Mutagen.Bethesda.Plugins.Records.Mapping;

public record RecordTypes(Type ClassType, Type GetterType, Type SetterType);

public static class MajorRecordTypeEnumerator
{
	private static readonly ConcurrentDictionary<GameCategory, List<RecordTypes>> Registrations = new();

	private static List<RecordTypes> GetRegistrations(GameCategory cat)
	{
		var categoryString = Enums<GameCategory>.ToStringFast((int) cat);

		return LoquiRegistration.StaticRegister.Registrations
			.Where(x =>
				x.ClassType.Namespace != null
			 && x.ClassType.Namespace.Contains(categoryString, StringComparison.Ordinal)
			 && x.GetterType.IsAssignableTo(typeof(IMajorRecordGetter)))
            .Select(x => new RecordTypes(x.ClassType, x.GetterType, x.SetterType))
            .ToList();
	}

	public static IEnumerable<RecordTypes> GetMajorRecordTypesFor(GameCategory cat)
	{
		return Registrations.GetOrAdd(cat, () => GetRegistrations(cat));
	}
}
