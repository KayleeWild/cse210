class ReflectionActivity : Activity
{
    // Variables:
    private string[] _promptList;
    private string[] _questionList;
    // Constructor:
    public ReflectionActivity(string name, string desc, string[] promptList, string[] questionList)
        : base(name, desc)
    {
        _duration = 0;  
        _promptList = promptList;
        _questionList = questionList;
    }
    // Method:
    public void RunReflection()
    {
        // Define random numbers
        int randomPrompt = GetRandomNumber(_promptList);
        int randomQuestion = GetRandomNumber(_questionList);
        // Start message
        DisplayStartMessage();
        // Display prompt
        Console.WriteLine(_promptList[randomPrompt]);
        Animation(4);
        // Define length of the activity in terms of time
        DateTime current = DateTime.Now;
        DateTime end = current.AddSeconds(_duration);
        // Display questions
        do
        {
            Console.WriteLine(_questionList[randomQuestion]);
            Animation(9);
            randomQuestion = GetRandomNumber(_questionList);
            current = DateTime.Now;
        } while(current < end);
        // End message
        DisplayEndMessage();
    }
}