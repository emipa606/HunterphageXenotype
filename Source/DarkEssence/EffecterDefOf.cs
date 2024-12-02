using RimWorld;
using Verse;

namespace DarkEssence;

[DefOf]
public static class EffecterDefOf
{
    public static EffecterDef FailSafeExit;

    static EffecterDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(EffecterDefOf));
    }
}