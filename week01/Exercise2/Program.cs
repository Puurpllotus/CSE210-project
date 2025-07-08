using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Score:");
        int input = int.Parse(Console.ReadLine());

        if (input >= 93)
        {
            Console.WriteLine("You got an A");
        }
        else if (input >= 90)
        {
            Console.WriteLine("You got an A-");
        }
        else if (input >= 87)
        {
            Console.WriteLine("You got a B+");
        }
        else if (input >= 83)
        {
            Console.WriteLine("You got a B");
        }
        else if (input >= 80)
        {
            Console.WriteLine("You got a B-");
        }
        else if (input >= 77)
        {
            Console.WriteLine("You got a C+");
        }
        else if (input >= 73)
        {
            Console.WriteLine("You got a C");
        }
        else if (input >= 70)
        {
            Console.WriteLine("You got a C-");
        }
        else if (input >= 67)
        {
            Console.WriteLine("You got a D+");
        }
        else if (input >= 63)
        {
            Console.WriteLine("You got a D");
        }
        else if (input >= 60)
        {
            Console.WriteLine("You got a D-");
        }
        else
        {
            Console.WriteLine("You got an F");
        }

        if (input >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}