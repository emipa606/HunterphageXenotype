using Verse;

namespace DarkEssence;

public class Gene_Adrenaline : Gene
{
    public override void PostAdd()
    {
        pawn.health.AddHediff(HediffDefOf.HyperRegenerative);
        base.PostAdd();
    }
}