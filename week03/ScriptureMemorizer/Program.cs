using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to choose a difficulty level
        Console.WriteLine("Choose a difficulty level:");
        Console.WriteLine("1. Easy (hide 1 word per turn)");
        Console.WriteLine("2. Medium (hide 2 words per turn)");
        Console.WriteLine("3. Hard (hide 4 words per turn)");
        Console.Write("Enter 1, 2, or 3: ");
        string choice = Console.ReadLine();

        int wordsToHide = choice switch
        {
            "1" => 1,
            "2" => 2,
            "3" => 4,
            _ => 2 // default to Medium if input is invalid
        };

        Reference reference = new Reference("Mosiah", 4, 29, 30);
        string scriptureText = "And finally, I cannot tell you all the things whereby ye may commit sin; for there are divers ways and means, even so many that I cannot number them. But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, and continue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not.";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;

            scripture.HideRandomWords(wordsToHide);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words hidden. Good job!");
    }
}
