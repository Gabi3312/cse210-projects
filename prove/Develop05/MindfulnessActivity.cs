using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration;

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {GetType().Name}!");
        Console.WriteLine(GetDescription());
        Console.Write("Please enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Pause(3); 
    }

    public abstract string GetDescription();

    public void EndActivity()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
        Pause(3); 
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }
}
