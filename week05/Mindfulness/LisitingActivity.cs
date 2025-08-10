using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        StartActivity();
        DisplayPrompt();
        Console.WriteLine("You may begin listing items after the countdown:");
        ShowCountdown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        EndActivity();
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        Console.WriteLine($"\n--- {_prompts[random.Next(_prompts.Count)]} ---");
    }
}
