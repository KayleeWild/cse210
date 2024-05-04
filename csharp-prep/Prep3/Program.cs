using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guess = int.Parse(guessString);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);
    }
}
