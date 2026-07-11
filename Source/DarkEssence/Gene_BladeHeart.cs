using System.Collections.Generic;
using Verse;

namespace DarkEssence;

public class Gene_BladeHeart : Gene
{
    public override void PostAdd()
    {
        base.PostAdd();
        EnsureBladeHeartHediff();
    }

    public override void PostRemove()
    {
        var hediff = pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.BladeHeartDicipline);
        if (hediff != null)
        {
            pawn.health.RemoveHediff(hediff);
        }

        base.PostRemove();
    }

    public override void Tick()
    {
        base.Tick();
        if (pawn.IsHashIntervalTick(60))
        {
            EnsureBladeHeartHediff();
        }
    }

    private void EnsureBladeHeartHediff()
    {
        if (!Active || pawn.health.hediffSet.HasHediff(HediffDefOf.BladeHeartDicipline))
        {
            return;
        }

        var parts = new List<BodyPartDef> { DarkEssenceDefof.Heart };
        HediffGiverUtility.TryApply(pawn, HediffDefOf.BladeHeartDicipline, parts, true);
    }
}
