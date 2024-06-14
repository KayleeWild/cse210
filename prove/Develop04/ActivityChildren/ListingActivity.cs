class ListingActivity : Activity
{
    // Variable:
    private string[] _promptList;
    // Constructor:
    public ListingActivity(string name, string desc, string[] prompts)
        : base(name, desc)
    {
        _duration = 0;
        _promptList = prompts;
    }
    // Methods:
    public void RunListing()
    {
        // Define variables
        int randomPrompt = GetRandomNumber(_promptList);
        int count = 0;
        // Start message
        DisplayStartMessage();
        // Define length of the activity in terms of time
        DateTime current = DateTime.Now;
        DateTime end = current.AddSeconds(_duration);
        // Display prompt and run activity
        Console.WriteLine(_promptList[randomPrompt]);
        Animation(1);
        do
        {
            Console.ReadLine();
            count ++;
            current = DateTime.Now;
        } while(current < end);
        // Display how many items they listed
        Console.WriteLine($"{count} items! That's quite the shell-ection! Perhaps we should shell-ebrate?!");
        // End message
        DisplayEndMessage();
    }

}