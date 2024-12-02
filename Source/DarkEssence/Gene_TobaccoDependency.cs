using Verse;

namespace DarkEssence;

public class Gene_TobaccoDependency : Gene
{
    public override void PostAdd()
    {
        pawn.health.AddHediff(HediffDefOf.TobaccoAddiction);
        base.PostAdd();
    }
}