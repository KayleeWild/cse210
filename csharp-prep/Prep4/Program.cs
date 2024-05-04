using System;

class Program
{
    static void Main(string[] args)
    {
        // Create new list and a variable for number additions
        List<int> numbers = new();
        int number = 99999999;

        // Ask user for a series of numbers, and append each one to a list.
        // Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } ;

        // Compute the sum/total of numbers in the list
        Console.WriteLine($"The sum is {numbers.Sum()}");
        // Compute the average
        Console.WriteLine($"The average is : {numbers.Average()}");
        // Find the max number in the list
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}