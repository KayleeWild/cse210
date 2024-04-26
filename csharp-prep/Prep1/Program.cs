using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask for first name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        //Ask for last name
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        //Display James Bond dialog
        Console.WriteLine($"\nYour name is {last_name}, {first_name} {last_name}.");
    }
}