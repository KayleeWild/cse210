using System;

class Program
{
    static void Main(string[] args)
    {
        // Create activity objects:
        BreathingActivity breathing = new("breathing"
            ,"This activity is as easy as breathing... literally! Taking time to focus on your breath helps you refocus and relax. This activity is meant for people and turtles alike.");
        ReflectionActivity reflection = new("reflection"
            ,"To help you dig deep and find self-appreciation, we've prepared a few questions for you to ponder on. Each one will reference a time in your life that you will be prompted to think about."
            ,["Think of a time when you felt God's love.","Think of a time when you did the right thing (even if it was hard).","Think of a time when you did something you didn't think you could do.","Think of a time when you did something kind without recieving credit."]
            ,["Why did this mean so much to you?","Was this the first time you did something like this?","What led you to do this thing?","How did you feel when you were done?","What made this time different, as opposed to other times that may not have worked?","What is your favorite thing about this experience?","What can you learn from this experience that applies elsewhere?","What did this experience teach you about yourself?","How can you remember this experience in the future?"]);
        ListingActivity listing = new("listing"
        ,"Counting blessings helps you appreciate what God does for you. This activity gives you time to list out specific blessings based on a provided category. List as many as you can, pressing [enter] after each one, until the time runs out."
        ,["People you appreciate:", "Personal Strengths:", "People you've gotten to help:", "Delicious food you've tried:", "Presents you've recieved:", "Gifts of the Spirit you've been given:", "Art you've appreciated (movies, songs, plays, paintings, etc.):"]);
        // Display Menu until quit
        int option;
        do 
        {
            Console.Clear();
            Console.WriteLine("Menu:\n1- Breathing\n2- Reflection\n3- Listing\n4- Quit\n");
            option = Int32.Parse(Console.ReadLine());
            if (option == 1)
            {
                breathing.RunBreathing();
            } else if (option == 2)
            {
                reflection.RunReflection();
            } else if (option == 3)
            {
                listing.RunListing();
            }
        } while (option != 4);
        Console.WriteLine("Thanks for taking a minute to be mindful. Have a happy day!");
    }
}