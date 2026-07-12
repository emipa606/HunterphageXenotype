using RimWorld;
using Verse;

namespace DarkEssence;

public class StatWorker_HunterphageMeleeDodge : StatWorker
{
    private const float HunterphageDodgeCap = 0.6f;

    public override float GetValueUnfinalized(StatRequest req, bool applyPostProcess = true)
    {
        var value = base.GetValueUnfinalized(req, applyPostProcess);
        if (applyPostProcess && value >= 0.5f && req is { HasThing: true, Thing: Pawn pawn } &&
            pawn.genes?.HasActiveGene(DarkEssenceDefof.Gene_Hunterphage_MeleeGifted) == true)
        {
            return value < HunterphageDodgeCap ? HunterphageDodgeCap : value;
        }

        return value;
    }
}