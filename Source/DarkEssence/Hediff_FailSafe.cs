using Verse;

namespace DarkEssence;

public class Hediff_FailSafe : HediffWithComps
{
    public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit = null)
    {
        base.Notify_PawnDied(dinfo, culprit);
        if (!pawn.Corpse.Spawned)
        {
            return;
        }

        pawn.Corpse.Destroy();
        var effecter = EffecterDefOf.FailSafeExit.Spawn();
        effecter.Trigger(new TargetInfo(pawn.Position, pawn.Map), TargetInfo.Invalid);
        effecter.Cleanup();
    }
}