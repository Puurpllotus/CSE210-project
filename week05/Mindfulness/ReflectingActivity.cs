using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone else.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?"
    };

    public ReflectingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        StartActivity();
        DisplayPrompt();
        Console.WriteLine("\nConsider the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(5);
        }

        EndActivity();
    }

    private void DisplayPrompt()
    {
        Random random = new Random();
        Console.WriteLine($"\n--- {_prompts[random.Next(_prompts.Count)]} ---");
    }

    private void DisplayQuestion()
    {
        Random random = new Random();
        Console.WriteLine($"> {_questions[random.Next(_questions.Count)]}");
    }
}
