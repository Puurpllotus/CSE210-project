using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnum = int.Parse(Console.ReadLine());

        return favnum;
    }
    static int SquareNumber(int num1)
    {
        int square = num1 * num1;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name} The square of your number is: {square}");
    }
}