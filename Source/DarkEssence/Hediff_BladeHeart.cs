using Verse;

namespace DarkEssence;

public abstract class Hediff_GeneBound : HediffWithComps
{
    protected abstract GeneDef RequiredGene { get; }

    public override bool ShouldRemove => base.ShouldRemove ||
                                         pawn.genes == null ||
                                         !pawn.genes.HasActiveGene(RequiredGene);
}

public class Hediff_BladeHeart : Hediff_GeneBound
{
    protected override GeneDef RequiredGene => DarkEssenceDefof.Gene_Hunterphage_BladeHeart;
}

public class Hediff_HyperRegenerative : Hediff_GeneBound
{
    protected override GeneDef RequiredGene => DarkEssenceDefof.Gene_Hunterphage_HyperHealing;
}

public class Hediff_DarkConstitution : Hediff_GeneBound
{
    protected override GeneDef RequiredGene => DarkEssenceDefof.Gene_Hunterphage_DarkConstitution;
}
