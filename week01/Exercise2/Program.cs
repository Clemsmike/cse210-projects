using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        int lastDigit = grade % 10;

        string letter;
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }
        else if (letter != "A" && letter != "F" && lastDigit >= 7)
        {
            sign = "+";
        }
        else if (letter != "A" && letter != "F" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You can do better next time.");
        }
    }
}