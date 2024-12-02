using RimWorld;

namespace DarkEssence;

public class CompProperties_Socialize : CompProperties_EffectWithDest
{
    public CompProperties_Socialize()
    {
        compClass = typeof(CompAbilityEffect_Socialize);
    }
}