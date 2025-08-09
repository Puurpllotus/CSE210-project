using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You completed {_duration} seconds of {_name}.");
        ShowSpinner(3);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> symbols = new List<string>() { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(symbols[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= symbols.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
