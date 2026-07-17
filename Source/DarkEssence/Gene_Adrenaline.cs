using Verse;

namespace DarkEssence;

public class Gene_Adrenaline : Gene_HediffBound
{
    protected override HediffDef BoundHediff => HediffDefOf.HyperRegenerative;
}