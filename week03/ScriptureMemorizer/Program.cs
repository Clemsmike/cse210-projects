using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // CREATIVE ENHANCEMENTS:
        // 1. A library of five scriptures is provided.
        // 2. Users can select a scripture or choose random selection.
        // 3. Users can adjust the number of words hidden per turn.

        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"),

            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths"),

            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"),

            new Scripture(
                new Reference("Psalm", 23, 1, 4),
                "The Lord is my shepherd I shall not want He maketh me to lie down in green pastures he leadeth me beside the still waters He restoreth my soul he leadeth me in the paths of righteousness for his name sake Yea though I walk through the valley of the shadow of death I will fear no evil for thou art with me thy rod and thy staff they comfort me"),

            new Scripture(
                new Reference("Romans", 8, 28),
                "And we know that all things work together for good to them that love God to them who are the called according to his purpose")
        };

        Console.WriteLine("==================================");
        Console.WriteLine("       SCRIPTURE MEMORIZER");
        Console.WriteLine("==================================");
        Console.WriteLine();

        Console.WriteLine("Choose a scripture:");

        for (int i = 0; i < scriptureLibrary.Count; i++)
{
    Console.WriteLine($"{i + 1}. {scriptureLibrary[i].GetReferenceDisplayText()}");
}

        Console.WriteLine("6. Choose a random scripture");

        Console.WriteLine();
        Console.Write("Enter your choice (1-6): ");

        string choice = Console.ReadLine();

        Random random = new Random();
        int selectedIndex;

        if (choice == "6")
        {
            selectedIndex = random.Next(scriptureLibrary.Count);
        }
        else if (int.TryParse(choice, out selectedIndex)
                 && selectedIndex >= 1
                 && selectedIndex <= scriptureLibrary.Count)
        {
            selectedIndex--;
        }
        else
        {
            Console.WriteLine("Invalid selection. Please restart and choose 1-6.");
            return;
        }

        Scripture scripture = scriptureLibrary[selectedIndex];

        Console.WriteLine();
        Console.Write("How many words should be hidden per turn? ");

        if (!int.TryParse(Console.ReadLine(), out int wordsToHide)
            || wordsToHide < 1)
        {
            Console.WriteLine("Please enter a valid positive number.");
            return;
        }

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Thank you for practising!");
                return;
            }

            scripture.HideRandomWords(wordsToHide);
        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Congratulations!");
        Console.WriteLine("You have successfully hidden every word.");
    }
}