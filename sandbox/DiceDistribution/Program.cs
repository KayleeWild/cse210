namespace DiceDistribution;

class Program
{
    static void PrepareTallyList(List<int> listParam)
    {
        for (int i=0; i<=12; i++)
        {
            listParam.Add(0);
        }
        // (The minimum roll of two dice is 2, "snake eyes,"
        //  so indexes [0] and [1] of this list will not be used)

    }

    static void ThrowLotsOfDice(List<int> talliesParam, int quota)
    {
        Console.WriteLine($"Now rolling {quota:n0} pairs of dice...");
        Random randomGenerator = new Random();
        for (int roll=0; roll < quota; roll++)
        {
            int die1 = randomGenerator.Next(1, 7);  // first die roll
            int die2 = randomGenerator.Next(1, 7);  // second die roll
            int total = die1 + die2;
            talliesParam[total]++;  // increment the tally for that particular dice sum
        }
        Console.WriteLine(" ... finished rolling. Distribution graph:");
    }

    static void DisplayResults(List<int> talliesParam, int quota)
    {
        int scale = quota/200;
        for (int i=2; i <= 12; i++)
        {
            Console.Write($"{i,3}: ");
            for (int graphUnit=0; graphUnit < talliesParam[i]/scale; graphUnit++)
            {
                Console.Write("#");
            }
            Console.WriteLine($" ({talliesParam[i]:n0})");
        }
        Console.WriteLine($" (Scale: each # represents {scale:n0} throws of dice.)");
    }

    static void Main(string[] args)
    { 
        // initialize a list for counting rolls of dice
        List<int> tallies = new List<int>();
        PrepareTallyList(tallies);
        
        // roll dice many times and track the results
        int experimentSize = 1_000_000_000;
        ThrowLotsOfDice(tallies, experimentSize);

        // display a graph of the tallies; should look somewhat like a triangular "bell curve"
        DisplayResults(tallies, experimentSize);
    }
}