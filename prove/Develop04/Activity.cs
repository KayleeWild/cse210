class Activity
{
    // Variables:
    protected string _name;
    protected string _description;
    protected int _duration; // < < in seconds
    // Constructors:
    public Activity(string name, string desc)
    {
        _name = name;
        _description = desc;
    }
    // Methods:
    /*Messages to be displayed*/
    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Namaste my homies!\nYou're just in time for the {_name} activity!\n{_description}");
        Console.WriteLine("How long will you be joining us today?");
        Console.WriteLine("(please write your response in seconds, or my pet turtle will be very sad.)\n");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"\nShell yeah! {_duration} seconds on the clock, which will start when turtle is done blinking ;) \nPrepare yourself for our {_name} activity, as it will begin momentarily...");
        Animation(6);
    }
    protected void DisplayEndMessage()
    {
        Console.WriteLine($"\n\nGreat job!");
        Animation(1);
        Console.WriteLine($"We hope you feel turtle-y ready to take on the day after doing the {_name} activty for {_duration} seconds.");
        Animation(6);
    }
    /*Countdown/animation stuf*/
    private void OpenTurtle()
    {
        Console.Write($"  _____     ____\n /      \\  |  o | \n|        |/ ___\\| \n|_________/     \n|_|_| |_|_|\n");
    }
    private void ClosedTurtle()
    {
        Console.Write($"  _____     ____\n /      \\  |  > | \n|        |/ ___\\| \n|_________/     \n|_|_| |_|_|\n");
    }
    private void getRidOfTurtle()
    {
        Console.SetCursorPosition(0, Console.CursorTop - 5);
        Console.Write(new string(' ', 5 * Console.WindowWidth + 1)); 
        Console.SetCursorPosition(0, Console.CursorTop - 5);
    }
    protected void Animation(int repeats)
    {
        int delay = 600;
        for (int i = 0; i < repeats; i++)
        {
            OpenTurtle();
            Thread.Sleep(delay);
            getRidOfTurtle();
            ClosedTurtle();
            Thread.Sleep(delay);
            getRidOfTurtle();
        }
    }
    protected void Countdown(int start)
    {
        for (int i = start; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    /*random number getter*/
    protected int GetRandomNumber(string[] array)
    {
        Random rando = new();
        int randomIndex = rando.Next(0, (array.Length - 1));
        return randomIndex;
    }
}