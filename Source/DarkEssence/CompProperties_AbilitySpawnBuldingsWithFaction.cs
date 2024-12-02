using RimWorld;
using Verse;

namespace DarkEssence;

public class CompProperties_AbilitySpawnBuldingsWithFaction : CompProperties_AbilityEffect
{
    public readonly bool allowOnBuildings = true;

    public bool sendSkipSignal = true;
    public ThingDef thingDef;

    public CompProperties_AbilitySpawnBuldingsWithFaction()
    {
        compClass = typeof(CompAbilityEffect_SpawnBuildingsWithFaction);
    }
}