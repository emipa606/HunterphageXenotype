using System.Collections.Generic;
using RimWorld;
using Verse;

namespace DarkEssence;

public class BladeHeartConditionalStatAffecter : ConditionalStatAffecter
{
    public override string Label => "";

    public override bool Applies(StatRequest req)
    {
        if (!ModsConfig.BiotechActive)
        {
            return false;
        }

        if (req is not { HasThing: true, Thing: Pawn pawn } || !pawn.RaceProps.Humanlike || !pawn.IsFighting())
        {
            return true;
        }

        var firstHediffOfDef = pawn.health.hediffSet?.GetFirstHediffOfDef(HediffDefOf.BladeHeartDicipline);
        if (firstHediffOfDef != null)
        {
            return false;
        }

        var list = new List<BodyPartDef> { DarkEssenceDefof.Heart };
        HediffGiverUtility.TryApply(pawn, HediffDefOf.BladeHeartDicipline, list, true);

        return true;
    }
}