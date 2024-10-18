using System;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();

            MindfulnessActivity activity;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.Run();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activity.Run();
                    break;
                case "3":
                    activity = new ListingActivity();
                    activity.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
