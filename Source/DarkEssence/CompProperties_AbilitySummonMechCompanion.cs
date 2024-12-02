using System.Collections.Generic;
using RimWorld;
using Verse;

namespace DarkEssence;

public class CompProperties_AbilitySummonMechCompanion : CompProperties_AbilityEffect
{
    public readonly bool allowOnBuildings = true;

    public IntRange Amount;
    public List<PawnKindDef> Automatons;

    public bool sendSkipSignal = true;

    public bool Weapon = false;

    public CompProperties_AbilitySummonMechCompanion()
    {
        compClass = typeof(CompAbilityEffect_AbilitySummonMechCompanion);
    }
}