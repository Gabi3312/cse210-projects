using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override string GetDescription()
    {
        return "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
    }

    public void Run()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(3); 

        Console.WriteLine("Start listing your thoughts. Type 'done' to finish.");
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done") break;
            responses.Add(response);
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        EndActivity();
    }
}
