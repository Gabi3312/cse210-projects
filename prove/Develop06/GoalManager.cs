public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore;

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RecordEvent(int goalIndex)
    {
        goals[goalIndex].RecordEvent();
        totalScore += goals[goalIndex].Points;
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals() { /* Save goals to a file */ }
    public void LoadGoals() { /* Load goals from a file */ }
}
