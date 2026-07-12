using Verse;

namespace DarkEssence;

public class Hediff_FailSafe : HediffWithComps
{
    public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit = null)
    {
        base.Notify_PawnDied(dinfo, culprit);
        var corpse = pawn.Corpse;
        if (corpse == null || !corpse.Spawned)
        {
            return;
        }

        var position = corpse.Position;
        var map = corpse.Map;
        corpse.Destroy();

        var effecter = EffecterDefOf.FailSafeExit.Spawn();
        effecter.Trigger(new TargetInfo(position, map), TargetInfo.Invalid);
        effecter.Cleanup();
    }
}
