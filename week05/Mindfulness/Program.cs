using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "3")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
            }
        }
    }
}
