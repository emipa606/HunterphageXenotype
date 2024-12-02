using RimWorld;
using Verse;

namespace DarkEssence;

[DefOf]
public static class DarkEssenceDefof
{
    [MayRequireBiotech] public static BodyPartDef Heart;

    static DarkEssenceDefof()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(DarkEssenceDefof));
    }
}