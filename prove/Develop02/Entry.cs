class Entry
{
    Random rando = new();
    // variables:
    public string _date;
    public string _prompt;
    public string _author;
    public string _entryText;
    public List<string> _promptList =
    ["When did I see the Lord's hand today?"
    , "What was embarrassing about today?"
    , "What is a new thought I had today?"
    , "What was the best thing I ate today?"
    , "Who did I connect with today?"];
    // methods:
     public string PickPrompt()
    {
        int randoPrompt = rando.Next(0, 4);
        return _promptList[randoPrompt];
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Author: {_author}");
        Console.Write($"Date: {_date}");
        Console.WriteLine($" - Prompt: {_prompt}");
        Console.WriteLine(_entryText);
    }
}