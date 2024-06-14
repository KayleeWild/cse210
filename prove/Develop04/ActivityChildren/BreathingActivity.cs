class BreathingActivity : Activity
{
    // Constructor:
    public BreathingActivity(string name, string desc)
        : base(name, desc)
    {
        _duration = 0;
    }
    // Method:
    public void RunBreathing()
    {
        // Start message
        DisplayStartMessage();
        // Define length of the activity in terms of time
        DateTime current = DateTime.Now;
        DateTime penultimate = current.AddSeconds(_duration - 8);
        // Breathing loop
        do
        {
            Console.Write("\nBreathe in...  ");
            Countdown(3);
            Console.Write("\nBreathe out... ");
            Countdown(5);
            current = DateTime.Now;
        } while (current < penultimate);
        Console.Write("\nLast one:");
        Console.Write("\nBreathe in...  ");
        Countdown(3);
        Console.Write("\nBreathe out... ");
        Countdown(5);
        // End message
        DisplayEndMessage();
    }

}