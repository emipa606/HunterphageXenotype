using RimWorld;
using Verse;

namespace DarkEssence;

public class Hediff_Socialize : HediffWithTarget
{
    public override string LabelBase
    {
        get
        {
            var array = new[] { base.LabelBase, " ", def.targetPrefix, " ", null };
            var num = 4;
            array[num] = target?.LabelShortCap;
            return string.Concat(array);
        }
    }

    public override void Notify_RelationAdded(Pawn otherPawn, PawnRelationDef relationDef)
    {
        if (otherPawn == target && (relationDef == PawnRelationDefOf.Lover || relationDef == PawnRelationDefOf.Fiance ||
                                    relationDef == PawnRelationDefOf.Spouse))
        {
            pawn.health.RemoveHediff(this);
        }
    }
}