using System;
public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Persons Name: {_name}");
        Console.WriteLine("Job List: ");
        
        foreach (Job job in _jobs)
        {
            job.Display();
        }

    }

}