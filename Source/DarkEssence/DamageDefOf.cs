using RimWorld;
using Verse;

namespace DarkEssence;

[DefOf]
public static class DamageDefOf
{
    public static DamageDef Corrosion;

    public static DamageDef Corruption;

    static DamageDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(DamageDefOf));
    }
}