public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        CompletedCount++;
        if (CompletedCount >= TargetCount)
        {
            IsComplete = true;
            Points += BonusPoints;
        }
    }

    public override string GetDetailsString() => $"{base.GetDetailsString()} Completed: {CompletedCount}/{TargetCount}";
}
