using System;
class Program
{
    static void Main(string[] args)
    {
        // welcome message
        Console.Clear();
        Console.WriteLine("\nWelcome to the Scripture Memorizer!!");
        string stringy = new string('~', 36);
        Console.WriteLine(stringy);
        string input;

        // hard code reference and verse(s) 
        // [THIS CAN BE CHANGED WITH NO REPURCUSSIONS!!] if changing, be sure to update the verse numbers as arguments for any time you call the verse's display method.
        Reference newReference = new("3 Nephi", 9, 10);
        newReference.Display();
        Console.WriteLine();
        Verse firstVerse = new("And it came to pass that when he had thus spoken, all the multitude, with one accord, did go forth with their sick and their afflicted, and their lame, and with their blind, and with their dumb, and with all them that were afflicted in any manner; and he did heal them every one as they were brought forth unto him.");
        firstVerse.Display(9);
        Verse secondVerse = new("And they did all, both they who had been healed and they who were whole, bow down at his feet, and did worship him; and as many as could come for the multitude did kiss his feet, insomuch that they did bathe his feet with their tears.");
        secondVerse.Display(10);

        // instructions for user
        Console.Write("\n\nEach time you press [Enter], 3 words will disappear. This will continue until you type 'quit' or until all the words have disappeared.");
        input = Console.ReadLine();

        // loopy loopy loop
        int firstRevealed = firstVerse.GetRevealedCount();
        int secondRevealed = secondVerse.GetRevealedCount();
        while (input != "quit" && (firstRevealed != 0 || secondRevealed != 0))
        {
            // clear console
            Console.Clear();
    
            // hide some words
            for (int i = 1; i <= 3; i++)
            {
                if (firstRevealed != 0)
                {
                    firstVerse.HideWord();
                    firstRevealed = firstVerse.GetRevealedCount();
                }
            }
            for (int i = 1; i <= 3; i++)
            {
                if (secondRevealed != 0)
                {
                    secondVerse.HideWord();
                    secondRevealed = secondVerse.GetRevealedCount();
                }
            }
            
            

            // display new scripture
            newReference.Display();
            Console.WriteLine();
            firstVerse.Display(9);
            secondVerse.Display(10);

            // instructions for user
            Console.Write("\n\nEach time you press [Enter], 3 words will disappear. This will continue until you type 'quit'.");
            input = Console.ReadLine();
        }
    }
}