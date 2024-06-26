using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // variables/objects:
        Menu session = new();
        int menuOption = 0;
        // methods:
        while (menuOption != 6)
        {
            session.DisplayMenu();
            menuOption = Int32.Parse(Console.ReadLine());
            if (menuOption == 1)
            {
                session.CreateNewGoal();
            } else if (menuOption == 2)
            {
                session.ListGoals();
            } else if (menuOption == 3)
            {
                session.SaveGoals();
            } else if (menuOption == 4)
            {
                session.LoadGoals();
            } else if (menuOption == 5)
            {
                session.RecordEvent();
            }
        }
        Console.Write("Thanks for goaling! Have a happy day :)");
    }
}