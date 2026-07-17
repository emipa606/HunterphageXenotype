using RimWorld;
using Verse;

namespace DarkEssence;

[DefOf]
public static class DarkEssenceDefof
{
    [MayRequireBiotech] public static BodyPartDef Heart;

    [MayRequireBiotech] public static GeneDef Gene_Hunterphage_MeleeGifted;

    [MayRequireBiotech] public static GeneDef Gene_Hunterphage_BladeHeart;

    [MayRequireBiotech] public static GeneDef Gene_Hunterphage_HyperHealing;

    [MayRequireBiotech] public static GeneDef Gene_Hunterphage_DarkConstitution;

    static DarkEssenceDefof()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(DarkEssenceDefof));
    }
}