using System.IO;
class Journal
{
    // variables:
    public List<Entry> _entryList = new(); 
    public string _fileName;
    // methods:
    public int DisplayMenu()
    {
        //Display journal with empty line at top for readability
        Console.WriteLine();
        Console.WriteLine("Journal Program Options:");
        Console.WriteLine("------------------------");
        Console.WriteLine("1- New Entry");
        Console.WriteLine("2- Display Journal");
        Console.WriteLine("3- Save Journal");
        Console.WriteLine("4- Load Journal");
        Console.WriteLine("5- quit");
        Console.Write("Your selection: ");
        //Read user choice and save as variable to return later
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        return choice;
    }
    public Entry NewEntry()
    {
        //Create new instance of Entry and display prompt
        Entry myEntry = new();
        myEntry._prompt = myEntry.PickPrompt();
        Console.WriteLine(myEntry._prompt);
        //Read user response and save it as variable
        Console.Write("> ");
        myEntry._entryText = Console.ReadLine();
        //Read current date and time when they hit enter
        DateTime rightNow = DateTime.Now;
        string rightNowText = $"{rightNow.ToShortDateString()} {rightNow.ToShortTimeString()}";
        myEntry._date = rightNowText;
        //Add to entry list and notify user
        _entryList.Add(myEntry);
        Console.WriteLine("\nEntry Saved. Select option 2 from menu to view all entries.");
        return myEntry;
    }
    public void DisplayJournal()
    {
        //iterate through list of entries and display attributes
        foreach (Entry entry in _entryList)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }
    public void SaveJournal()
    {
        //Prompt user for filename
        Console.WriteLine("What file name would you like this journal saved in?\n(Please use lowercase, use _ for any spaces, and include .txt at the end)");
        _fileName = Console.ReadLine();
        //Save current journal (complete list of entries) to that file location
        using (StreamWriter outputFile = new(_fileName))
        {
            //Add necessary elements to the file
            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine($"{entry._date}| {entry._prompt}| {entry._entryText}");
            }
        }
    }
    public void LoadJournal()
    {
        Console.WriteLine("What file name would you like this journal loaded from?\n(Please use lowercase, use _ for any spaces, and include .txt at the end)");
        string _loadFileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_loadFileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry loadEntry = new();
            loadEntry._date = parts[0];
            loadEntry._prompt = parts[1];
            loadEntry._entryText = parts[2];
            _entryList.Add(loadEntry);
        }
    }
}
