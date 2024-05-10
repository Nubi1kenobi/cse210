using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); //clears the console for a fresher look
        Console.WriteLine("Hello Learning02 World!");

        Resume myResume = new Resume();
        myResume._name = "Bryan C. Stauch"; 
        
        Job job1 = new Job();
        job1._company = "Comfort Systems USA";
        job1._jobTitle = "Building Automation Specialist";
        job1._startYear = 2010;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Expanse Electrical";
        job2._jobTitle = "Automation Tech II";
        job2._startYear = 2023;
        job2._endYear = 2032;

        myResume._jobs.Add(job2);
        myResume._jobs.Add(job1);
        
        myResume.Display();


        
    }
}