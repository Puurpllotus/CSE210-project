using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public void Run()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            Console.Write("Now breathe out... ");
            ShowCountdown(4);
        }

        EndActivity();
    }
}
