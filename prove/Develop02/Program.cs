using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new();
        int response = myJournal.DisplayMenu();
        while (response != 5)
        {
            //Determine response and take appropriate action
            if (response == 1)
            {
                Entry myEntry = myJournal.NewEntry();
            }
            else if (response == 2)
            {
                myJournal.DisplayJournal();
            }
            else if (response == 3)
            {
                myJournal.SaveJournal();
            }
            else if (response == 4)
            {
                myJournal.LoadJournal();
            }
            //Display menu again to navigate program
            response = myJournal.DisplayMenu();
        }
        Console.WriteLine("Have a happy day :)");
    }
}