using System.Collections.Generic;
using Verse;

namespace DarkEssence;

public class Gene_BladeHeart : Gene_HediffBound
{
    protected override HediffDef BoundHediff => HediffDefOf.BladeHeartDicipline;

    protected override void AddBoundHediff()
    {
        var parts = new List<BodyPartDef> { DarkEssenceDefof.Heart };
        HediffGiverUtility.TryApply(pawn, BoundHediff, parts, true);
    }
}
