using RimWorld;
using Verse;

namespace DarkEssence;

[DefOf]
public static class ThingDefOf
{
    public static ThingDef Mote_CriticalHit;

    static ThingDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
    }
}