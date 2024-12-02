using RimWorld;
using Verse;

namespace DarkEssence;

public class CompAbilityEffect_AbilitySummonMechCompanion : CompAbilityEffect
{
    public new CompProperties_AbilitySummonMechCompanion Props => (CompProperties_AbilitySummonMechCompanion)props;

    public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
    {
        Pawn pawn;
        for (var i = 0; i < Props.Amount.RandomInRange; i += (int)pawn.kindDef.combatPower)
        {
            pawn = PawnGenerator.GeneratePawn(Props.Automatons.RandomElement());
            GenSpawn.Spawn(pawn, target.Cell, parent.pawn.Map).SetFaction(Faction.OfAncients);
            pawn.health.AddHediff(HediffDefOf.FailSafe);
        }
    }

    public override bool Valid(LocalTargetInfo target, bool throwMessages = false)
    {
        if (!target.Cell.Filled(parent.pawn.Map) &&
            (target.Cell.GetFirstBuilding(parent.pawn.Map) == null || Props.allowOnBuildings))
        {
            return true;
        }

        if (throwMessages)
        {
            Messages.Message(
                "CannotUseAbility".Translate(parent.def.label) + ": " + "AbilityOccupiedCells".Translate(),
                target.ToTargetInfo(parent.pawn.Map), MessageTypeDefOf.RejectInput, false);
        }

        return false;
    }
}