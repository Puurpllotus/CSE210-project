using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.Write("What is the magic number?");
        //int guess = int.Parse (Console.ReadLine());

        Random rand = new Random();
        int num = rand.Next(1, 101);

        int guess = -1;

        while (guess != num)

        {
            Console.WriteLine("what is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (num > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (num < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}