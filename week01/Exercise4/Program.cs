using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, press 0 when finished.");
        List<int> number = new List<int>();

        int num = -1;
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            if (input == 0)
            {
                break;
            }
            else if (input !=0)
            {
                number.Add(input);
            }
            
        }
        int sum = 0;
        foreach (int num1 in number)
        {
            sum += num1;
        }


        Console.WriteLine($"The sum is: {sum}");
        float average = ((float)sum) / number.Count;
        Console.WriteLine($"The average is: {average}");

          int max = number[0];

        foreach (int num1 in number)
        {
            if (num1 > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = num1;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}