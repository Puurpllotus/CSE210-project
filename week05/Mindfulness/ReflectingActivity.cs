using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() 
        : base("Reflecting Activity", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("When you have something in mind, press Enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(5);
    }

    private void DisplayQuestions()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
        }
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}
