using Verse;

namespace DarkEssence;

public class Hediff_BladeHeart : HediffWithComps
{
    public override bool ShouldRemove => base.ShouldRemove ||
                                         (pawn.genes != null &&
                                          !pawn.genes.HasActiveGene(DarkEssenceDefof.Gene_Hunterphage_BladeHeart));
}
