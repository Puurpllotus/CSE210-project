using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        mainJob job1 = new mainJob("Software Engineer", "Microsoft", 2020, 2024);
        mainJob job2 = new mainJob("Manager", "Apple", 2018, 2020);

        // Create a resume instance
        Resume resume1 = new Resume("Steven Walker");

        // Add jobs to the resume
        resume1.AddJob(job1);
        resume1.AddJob(job2);

        // Display the resume
        resume1.Display();
    }
}


public class Resume
{
    public string _name;
    public List<mainJob> _jobs = new List<mainJob>();

    public Resume(string name)
    {
        _name = name;
    }

    public void AddJob(mainJob job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");


        foreach (mainJob job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
