using RimWorld;
using Verse;

namespace DarkEssence;

[DefOf]
public static class HediffDefOf
{
    public static HediffDef Socialize;

    public static HediffDef HyperRegenerative;

    public static HediffDef TobaccoAddiction;

    public static HediffDef BladeHeartDicipline;

    public static HediffDef DarkConstitution;

    public static HediffDef FailSafe;

    static HediffDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
    }
}