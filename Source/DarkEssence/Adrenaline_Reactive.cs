using Verse;

namespace DarkEssence;

public class Adrenaline_Reactive : HediffComp
{
    private readonly HediffDef Adrenalinehigh = DefDatabase<HediffDef>.GetNamed("AdrenalineHigh");

    private bool Pain => Pawn.health.InPainShock;

    public override void CompPostTick(ref float severityAdjustment)
    {
        if (Pain)
        {
            Pawn.health.AddHediff(Adrenalinehigh);
        }
    }
}