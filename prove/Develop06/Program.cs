public class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();

        
        manager.AddGoal(new SimpleGoal("Run a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read scriptures", 100));
        manager.AddGoal(new ChecklistGoal("Temple visits", 50, 10, 500));

        manager.DisplayGoals();
        
    }
}
