using RimWorld;
using Verse;

namespace DarkEssence;

public class CompAbilityEffect_SpawnBuildingsWithFaction : CompAbilityEffect
{
    public new CompProperties_AbilitySpawnBuldingsWithFaction Props =>
        (CompProperties_AbilitySpawnBuldingsWithFaction)props;

    public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
    {
        base.Apply(target, dest);
        GenSpawn.Spawn(Props.thingDef, target.Cell, parent.pawn.Map).SetFaction(Faction.OfPlayer);
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