using Verse;

namespace DarkEssence;

public class Hediff_DarkChi : HediffWithComps
{
    private readonly int tickMax = 1;

    private int tickCounter;

    public override void Tick()
    {
        base.Tick();
        tickCounter++;
        if (tickCounter <= tickMax || !Rand.Chance(0.1f))
        {
            return;
        }

        pawn.TakeDamage(new DamageInfo(DamageDefOf.Corruption, 20f, 0f, -20f));
        tickCounter = 0;
    }
}