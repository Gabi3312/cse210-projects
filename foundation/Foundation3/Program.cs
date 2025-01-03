using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 45, 15.0),
            new Swimming(new DateTime(2022, 11, 3), 20, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
