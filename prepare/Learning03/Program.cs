using System;

class Program
{
    static void Main(string[] args)
    {
        string value;
        double deciValue;
        Fraction f1 = new();
        Fraction f2 = new(5);
        Fraction f3 = new(3, 4);
        Fraction f4 = new(1, 3);
        value = f1.GetFractionString();
        Console.WriteLine(value);
        deciValue = f1.GetDecimalValue();
        Console.WriteLine(deciValue);
        value = f2.GetFractionString();
        Console.WriteLine(value);
        deciValue = f2.GetDecimalValue();
        Console.WriteLine(deciValue);
        value = f3.GetFractionString();
        Console.WriteLine(value);
        deciValue = f3.GetDecimalValue();
        Console.WriteLine(deciValue);
        value = f4.GetFractionString();
        Console.WriteLine(value);
        deciValue = f4.GetDecimalValue();
        Console.WriteLine(deciValue);
    }
}