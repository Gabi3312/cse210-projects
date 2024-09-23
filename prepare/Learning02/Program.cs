using System;

class Program
{
    static void Main(string[] args)
    {
       job1 = new Job();
       job1._jobTitle = "Software Development";
       job1._company = "Spotify";
       job1._startYear = 2023;
       job1._endYear = 2024;


       
       job job2 = new Job();
       job2._jobTitle = "Administrative Assistant";
       job2._company = "Google";
       job2._startYear = 2022;
       job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Gabriel Oros";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}