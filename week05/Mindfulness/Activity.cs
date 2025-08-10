using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Encouragement messages for exceeding requirements
    private string[] _encouragements = new string[]
    {
        "Great job! Keep going!",
        "You’re doing amazing!",
        "That’s the spirit!",
        "Keep up the great work!",
        "Fantastic effort!"
    };

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("\nEnter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    protected void EndActivity()
    {
        Console.WriteLine("\nWell done!");
        ShowEncouragement(); // <-- Added feature here
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(300);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void ShowEncouragement() // New method to show encouragement messages
    {
        Random random = new Random();
        int index = random.Next(_encouragements.Length);
        Console.WriteLine(_encouragements[index]);
    }
}
