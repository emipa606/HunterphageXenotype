using Verse;

namespace DarkEssence;

public class Gene_DarkConstitution : Gene
{
    public override void PostAdd()
    {
        pawn.health.AddHediff(HediffDefOf.DarkConstitution);
        base.PostAdd();
    }
}