// Creativity Feature: Journal Statistics allows users to see
// the total number of entries stored in their journal.

using System;
using System.IO;

Journal journal = new Journal();
PromptGenerator promptGenerator = new PromptGenerator();

bool running = true;

while (running)
{
Console.WriteLine("\nJOURNAL PROGRAM");
Console.WriteLine("1. Write");
Console.WriteLine("2. Display");
Console.WriteLine("3. Load");
Console.WriteLine("4. Save");
Console.WriteLine("5. Journal Statistics");
Console.WriteLine("6. Quit");

Console.Write("What would you like to do? ");
string choice = Console.ReadLine() ?? "";

switch (choice)
{
    case "1":
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        Console.Write("> ");

        string response = Console.ReadLine() ?? "";

        Entry newEntry = new Entry();
        newEntry._date = DateTime.Now.ToShortDateString();
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        journal.AddEntry(newEntry);

        Console.WriteLine("Your journal entry has been saved.");
        break;

    case "2":
        journal.DisplayAll();
        break;

    case "3":
        Console.Write("Enter filename: ");
        string loadFilename = Console.ReadLine() ?? "";

        if (File.Exists(loadFilename))
        {
            journal.LoadFromFile(loadFilename);
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. Check the filename.");
        }

        break;

    case "4":
        Console.Write("Enter filename: ");
        string saveFilename = Console.ReadLine() ?? "";
        journal.SaveToFile(saveFilename);
        Console.WriteLine("Journal saved.");
        break;

    case "5":
        journal.DisplayStatistics();
        break;

    case "6":
        running = false;
        Console.WriteLine("Thank you for using the Journal Program!");
        break;

    default:
        Console.WriteLine("Invalid choice. Please select a number from 1 to 6.");
        break;
}

}