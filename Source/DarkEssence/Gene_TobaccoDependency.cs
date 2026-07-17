using Verse;

namespace DarkEssence;

public class Gene_TobaccoDependency : Gene_HediffBound
{
    protected override HediffDef BoundHediff => HediffDefOf.TobaccoAddiction;
}