using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathy = new("Kaylee Wright", "Fractions", "4.3", "11-23 odds");
        WritingAssignment writey = new("Kaylee Wright", "How to talk to peeps", "A complete guide to talking with peeps");
        Console.WriteLine(mathy.GetSummary());
        Console.WriteLine(mathy.GetHomeworkList());
        Console.WriteLine(writey.GetSummary());
        Console.WriteLine(writey.GetWritingInformation());
    }
}