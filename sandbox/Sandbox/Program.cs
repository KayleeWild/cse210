using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            int delay = 100;
            Console.Write("/\b");
            Thread.Sleep(delay);
            Console.Write("-\b");
            Thread.Sleep(delay);
            Console.Write("\\\b");
            Thread.Sleep(delay);
            Console.Write("|\b");
            Thread.Sleep(delay);
        }
    }
}