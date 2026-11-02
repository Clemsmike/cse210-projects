using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty list
        List<int> numbers = new List<int>();

        // Receive numbers from the user
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number (0 to finish): ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Check whether the list is empty
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Calculate the sum
        int sum = 0;

        foreach (int item in numbers)
        {
            sum += item;
        }

        // Calculate the average
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");

        // Find the largest and smallest positive numbers
        int largest = numbers[0];
        int smallestPositive = int.MaxValue;

        foreach (int item in numbers)
        {
            if (item > largest)
            {
                largest = item;
            }

            if (item > 0 && item < smallestPositive)
            {
                smallestPositive = item;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive number was entered.");
        }

        // Sort the numbers in ascending order
        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}