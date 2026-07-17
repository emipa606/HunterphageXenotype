using Verse;

namespace DarkEssence;

public abstract class Gene_HediffBound : Gene
{
    protected abstract HediffDef BoundHediff { get; }

    public override void PostAdd()
    {
        base.PostAdd();
        SynchronizeHediff();
    }

    public override void PostRemove()
    {
        RemoveBoundHediff();
        base.PostRemove();
    }

    public override void Tick()
    {
        base.Tick();
        if (pawn.IsHashIntervalTick(60))
        {
            SynchronizeHediff();
        }
    }

    protected virtual void AddBoundHediff()
    {
        pawn.health.AddHediff(BoundHediff);
    }

    private void SynchronizeHediff()
    {
        if (!Active)
        {
            RemoveBoundHediff();
            return;
        }

        if (!pawn.health.hediffSet.HasHediff(BoundHediff))
        {
            AddBoundHediff();
        }
    }

    private void RemoveBoundHediff()
    {
        var hediff = pawn.health.hediffSet.GetFirstHediffOfDef(BoundHediff);
        if (hediff != null)
        {
            pawn.health.RemoveHediff(hediff);
        }
    }
}