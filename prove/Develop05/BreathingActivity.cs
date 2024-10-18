using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public override string GetDescription()
    {
        return "This activity will help you relax by guiding you through breathing in and out slowly.";
    }

    public void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Pause(4); 
            Console.WriteLine("Breathe out...");
            Pause(4); 
        }

        EndActivity();
    }
}
