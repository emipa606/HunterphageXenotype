using RimWorld;
using Verse;

namespace DarkEssence;

public class CompAbilityEffect_Socialize : CompAbilityEffect_WithDest
{
    private const int MinAge = 16;

    public override bool HideTargetPawnTooltip => true;

    public override TargetingParameters targetParams => new TargetingParameters
    {
        canTargetSelf = true,
        canTargetBuildings = false,
        canTargetAnimals = false,
        canTargetMechs = false
    };

    public override void Apply(LocalTargetInfo target, LocalTargetInfo dest)
    {
        base.Apply(target, dest);
        var pawn = target.Pawn;
        var firstHediffOfDef = pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.Socialize);
        if (firstHediffOfDef != null)
        {
            pawn.health.RemoveHediff(firstHediffOfDef);
        }

        var hediff_Socialize =
            (Hediff_Socialize)HediffMaker.MakeHediff(HediffDefOf.Socialize, pawn, pawn.health.hediffSet.GetBrain());
        hediff_Socialize.target = dest.Thing;
        var hediffComp_Disappears = hediff_Socialize.TryGetComp<HediffComp_Disappears>();
        if (hediffComp_Disappears != null)
        {
            var num = parent.def.EffectDuration(parent.pawn);
            num *= pawn.GetStatValue(StatDefOf.PsychicSensitivity);
            hediffComp_Disappears.ticksToDisappear = num.SecondsToTicks();
        }

        pawn.health.AddHediff(hediff_Socialize);
    }

    public override bool CanApplyOn(LocalTargetInfo target, LocalTargetInfo dest)
    {
        return Valid(target);
    }

    public override bool ValidateTarget(LocalTargetInfo target, bool showMessages = true)
    {
        var pawn = selectedTarget.Pawn;
        var pawn2 = target.Pawn;
        if (pawn == pawn2)
        {
            return false;
        }

        if (pawn == null || pawn2 == null)
        {
            return base.ValidateTarget(target, showMessages);
        }

        if (pawn.ageTracker.AgeBiologicalYearsFloat < MinAge)
        {
            Messages.Message(
                "CannotUseAbility".Translate(parent.def.label) + ": " + "AbilityCantApplyTooYoung".Translate(pawn),
                pawn, MessageTypeDefOf.RejectInput, false);
            return false;
        }

        if (pawn2.ageTracker.AgeBiologicalYearsFloat < MinAge)
        {
            Messages.Message(
                "CannotUseAbility".Translate(parent.def.label) + ": " + "AbilityCantApplyTooYoung".Translate(pawn2),
                pawn2, MessageTypeDefOf.RejectInput, false);
            return false;
        }

        if (pawn.story.traits.HasTrait(TraitDefOf.Bisexual))
        {
            return base.ValidateTarget(target, showMessages);
        }

        var gender = pawn.gender;
        var gender2 = pawn.story.traits.HasTrait(TraitDefOf.Gay) ? gender : gender.Opposite();

        if (pawn2.gender == gender2)
        {
            return base.ValidateTarget(target, showMessages);
        }

        Messages.Message(
            "CannotUseAbility".Translate(parent.def.label) + ": " +
            "AbilityCantApplyWrongAttractionGender".Translate(pawn, pawn2), pawn, MessageTypeDefOf.RejectInput,
            false);
        return false;
    }

    public override bool Valid(LocalTargetInfo target, bool throwMessages = false)
    {
        var pawn = target.Pawn;
        if (pawn == null)
        {
            return true;
        }

        if (!pawn.story.traits.HasTrait(TraitDefOf.Asexual))
        {
            return AbilityUtility.ValidateNoMentalState(pawn, throwMessages, parent);
        }

        if (throwMessages)
        {
            Messages.Message(
                "CannotUseAbility".Translate(parent.def.label) + ": " + "AbilityCantApplyOnAsexual".Translate(),
                pawn, MessageTypeDefOf.RejectInput, false);
        }

        return false;
    }

    public override string ExtraLabelMouseAttachment(LocalTargetInfo target)
    {
        return selectedTarget.IsValid ? "SocialFor".Translate() : "Social".Translate();
    }
}