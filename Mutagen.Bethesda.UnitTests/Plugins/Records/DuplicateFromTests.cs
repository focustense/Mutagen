using FluentAssertions;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins.Cache.Internals.Implementations;
using Mutagen.Bethesda.Testing;
using Xunit;

namespace Mutagen.Bethesda.UnitTests.Plugins.Records;

public class DuplicateFromTests : IClassFixture<LoquiUse>
{
    [Fact]
    public void DoNothing()
    {
        var mod = new SkyrimMod(TestConstants.PluginModKey, SkyrimRelease.SkyrimSE);
        var npc = mod.Npcs.AddNew();
        mod.DuplicateFromOnlyReferenced(mod.ToMutableLinkCache(), TestConstants.PluginModKey2);
        mod.EnumerateMajorRecords().Should().HaveCount(1);
        mod.Npcs.Should().HaveCount(1);
        mod.Npcs.First().Should().BeSameAs(npc);
    }

    [Fact]
    public void SelfPass()
    {
        Assert.Throws<ArgumentException>(() =>
        {
            var mod = new SkyrimMod(TestConstants.PluginModKey, SkyrimRelease.SkyrimSE);
            mod.DuplicateFromOnlyReferenced(mod.ToMutableLinkCache(), mod.ModKey);
        });
    }

    [Fact]
    public void TypicalExtraction()
    {
        var modToExtract = new SkyrimMod(TestConstants.PluginModKey, SkyrimRelease.SkyrimSE);
        var npc = modToExtract.Npcs.AddNew();
        var race = modToExtract.Races.AddNew();
        race.CloseLootSound.SetTo(modToExtract.SoundDescriptors.AddNew());
        var unneededRace = modToExtract.Races.AddNew();

        var targetMod = new SkyrimMod(TestConstants.PluginModKey2, SkyrimRelease.SkyrimSE);
        targetMod.Npcs.Add(npc);
        var safeNpc = targetMod.Npcs.AddNew();
        safeNpc.Race = new FormLink<IRaceGetter>(race.FormKey);

        var linkCache = new MutableLoadOrderLinkCache<ISkyrimMod, ISkyrimModGetter>(modToExtract, targetMod);

        targetMod.DuplicateFromOnlyReferenced(linkCache, modToExtract.ModKey, out var mapping);
        targetMod.Npcs.Should().HaveCount(2);
        targetMod.Races.Should().HaveCount(1);
        targetMod.SoundDescriptors.Should().HaveCount(1);
        targetMod.EnumerateMajorRecords().Should().HaveCount(4);
        targetMod.Npcs.Should().Contain(safeNpc);
        var newRaceFormKey = mapping[race.FormKey];
        var newRace = targetMod.Races.First();
        newRace.FormKey.Should().Be(newRaceFormKey);
        safeNpc.Race.FormKey.Should().Be(newRaceFormKey);
    }

    [Fact]
    public void DuplicateReference()
    {
        var modToExtract = new SkyrimMod(TestConstants.PluginModKey, SkyrimRelease.SkyrimSE);
        var npc = modToExtract.Npcs.AddNew();
        var race = modToExtract.Races.AddNew();
        race.CloseLootSound.SetTo(modToExtract.SoundDescriptors.AddNew());
        var unneededRace = modToExtract.Races.AddNew();

        var targetMod = new SkyrimMod(TestConstants.PluginModKey2, SkyrimRelease.SkyrimSE);
        targetMod.Npcs.Add(npc);
        var safeNpc = targetMod.Npcs.AddNew();
        safeNpc.Race = new FormLink<IRaceGetter>(race.FormKey);
        var safeNpc2 = targetMod.Npcs.AddNew();
        safeNpc2.Race = new FormLink<IRaceGetter>(race.FormKey);

        var linkCache = new MutableLoadOrderLinkCache<ISkyrimMod, ISkyrimModGetter>(modToExtract, targetMod);

        targetMod.DuplicateFromOnlyReferenced(linkCache, modToExtract.ModKey, out var mapping);
        targetMod.Npcs.Should().HaveCount(3);
        targetMod.Races.Should().HaveCount(1);
        targetMod.SoundDescriptors.Should().HaveCount(1);
        targetMod.EnumerateMajorRecords().Should().HaveCount(5);
        targetMod.Npcs.Should().Contain(safeNpc);
        targetMod.Npcs.Should().Contain(safeNpc2);
        var newRaceFormKey = mapping[race.FormKey];
        var newRace = targetMod.Races.First();
        newRace.FormKey.Should().Be(newRaceFormKey);
        safeNpc.Race.FormKey.Should().Be(newRaceFormKey);
    }

    [Fact]
    public void TypedExtraction()
    {
        var modToExtract = new SkyrimMod(TestConstants.PluginModKey, SkyrimRelease.SkyrimSE);
        var npc = modToExtract.Npcs.AddNew();
        var race = modToExtract.Races.AddNew();
        race.CloseLootSound.SetTo(modToExtract.SoundDescriptors.AddNew());
        var unneededRace = modToExtract.Races.AddNew();

        var targetMod = new SkyrimMod(TestConstants.PluginModKey2, SkyrimRelease.SkyrimSE);
        targetMod.Npcs.Add(npc);
        var safeNpc = targetMod.Npcs.AddNew();
        safeNpc.Race = new FormLink<IRaceGetter>(race.FormKey);

        var linkCache = new MutableLoadOrderLinkCache<ISkyrimMod, ISkyrimModGetter>(modToExtract, targetMod);

        targetMod.DuplicateFromOnlyReferenced(linkCache, modToExtract.ModKey, out var mapping, typeof(INpcGetter));
        targetMod.Npcs.Should().HaveCount(2);
        targetMod.Races.Should().HaveCount(1);
        targetMod.SoundDescriptors.Should().HaveCount(1);
        targetMod.EnumerateMajorRecords().Should().HaveCount(4);
        targetMod.Npcs.Should().Contain(safeNpc);
        var newRaceFormKey = mapping[race.FormKey];
        var newRace = targetMod.Races.First();
        newRace.FormKey.Should().Be(newRaceFormKey);
        safeNpc.Race.FormKey.Should().Be(newRaceFormKey);
    }

    [Fact]
    public void MistypedExtraction()
    {
        var modToExtract = new SkyrimMod(TestConstants.PluginModKey, SkyrimRelease.SkyrimSE);
        var npc = modToExtract.Npcs.AddNew();
        var race = modToExtract.Races.AddNew();
        race.CloseLootSound.SetTo(modToExtract.SoundDescriptors.AddNew());
        var unneededRace = modToExtract.Races.AddNew();

        var targetMod = new SkyrimMod(TestConstants.PluginModKey2, SkyrimRelease.SkyrimSE);
        targetMod.Npcs.Add(npc);
        var safeNpc = targetMod.Npcs.AddNew();
        safeNpc.Race = new FormLink<IRaceGetter>(race.FormKey);

        var linkCache = new MutableLoadOrderLinkCache<ISkyrimMod, ISkyrimModGetter>(modToExtract, targetMod);

        targetMod.DuplicateFromOnlyReferenced(linkCache, modToExtract.ModKey, out var mapping, typeof(IAmmunitionGetter));
        targetMod.EnumerateMajorRecords().Should().HaveCount(2);
        targetMod.Npcs.Should().HaveCount(2);
        targetMod.Npcs.Should().Contain(safeNpc);
        targetMod.Npcs.Should().Contain(npc);
    }
}