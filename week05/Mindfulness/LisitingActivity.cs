using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() 
        : base("Listing Activity", "This activity will help you focus on the good things in your life.")
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        return items;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = GetListFromUser();
        _count = responses.Count;

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
}
