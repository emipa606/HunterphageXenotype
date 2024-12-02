using Verse;

namespace DarkEssence;

public class Hediff_CorrosiveAcid : HediffWithComps
{
    private readonly int tickMax = 1;

    private int tickCounter;

    public object Corrosion { get; private set; }

    public override void Tick()
    {
        base.Tick();
        tickCounter++;
        if (tickCounter <= tickMax || !Rand.Chance(0.03f))
        {
            return;
        }

        pawn.TakeDamage(new DamageInfo(DamageDefOf.Corrosion, 10f, 0f, -10f));
        tickCounter = 0;
    }
}