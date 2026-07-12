using Verse;

namespace DarkEssence;

public class Hediff_FailSafe : HediffWithComps
{
    public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit = null)
    {
        base.Notify_PawnDied(dinfo, culprit);
        if (pawn.Corpse is not { Spawned: true })
        {
            return;
        }

        var position = pawn.Corpse.Position;
        var map = pawn.Corpse.Map;
        pawn.Corpse.Destroy();

        var effecter = EffecterDefOf.FailSafeExit.Spawn();
        effecter.Trigger(new TargetInfo(position, map), TargetInfo.Invalid);
        effecter.Cleanup();
    }
}