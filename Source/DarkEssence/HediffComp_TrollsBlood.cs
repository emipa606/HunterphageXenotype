using System.Linq;
using Verse;

namespace DarkEssence;

public class HediffComp_TrollsBlood : HediffComp
{
    private int ticksToHeal;

    public HediffCompProperties_TrollsBlood Props => (HediffCompProperties_TrollsBlood)props;

    public override void CompPostMake()
    {
        base.CompPostMake();
        ResetTicksToHeal();
    }

    private void ResetTicksToHeal()
    {
        ticksToHeal = Rand.Range(1, 2) * 100;
    }

    public override void CompPostTick(ref float severityAdjustment)
    {
        ticksToHeal--;
        if (ticksToHeal > 0)
        {
            return;
        }

        TryHealRandomPermanentWound(Pawn, parent.LabelCap);
        ResetTicksToHeal();
    }

    public static void TryHealRandomPermanentWound(Pawn pawn, string cause)
    {
        if (!pawn.health.hediffSet.hediffs.Where(hd => hd.IsPermanent() || hd.def.chronic || hd.def.displayWound)
                .TryRandomElement(out var result))
        {
            return;
        }

        HealthUtility.Cure(result);
    }

    public override void CompExposeData()
    {
        Scribe_Values.Look(ref ticksToHeal, "ticksToHeal");
    }

    public override string CompDebugString()
    {
        return "ticksToHeal: " + ticksToHeal;
    }
}