using System.IO;
class Menu
{
    // variables:
    public List<Goal> _goalList = new();
    public int totalPoints = 0;
    // Methods:
    public void DisplayMenu()
        {
            //// create box around points!!!!!
            Console.WriteLine($"You have {totalPoints} points.");
            Console.Write(
            "\nMenu Options:\n" +
            "    1. Create New Goal\n" +
            "    2. List Goals\n" +
            "    3. Save Goals\n" +
            "    4. Load Goals\n" +
            "    5. Record Event\n" +
            "    6. Quit\n" +
            "Select a choice from the menu: "
            );
        }
    public void CreateNewGoal()
    {
        Console.Write(
        "The types of goals are:\n" +
        "   1. Simple Goal\n" +
        "   2. Eternal Goal\n" +
        "   3. Checklist Goal\n" +
        "Which type of goal would you like to create? ");
        int goalType = Int32.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("How many points do you want associated with this goal? ");
        int points = Int32.Parse(Console.ReadLine());
        Console.Write(
        "The areas of growth are:\n" +
        "   1. Intellectual\n" +
        "   2. Physical\n" +
        "   3. Spiritual\n" +
        "   4. Social\n" +
        "Which area of growth does your goal fall under? ");
        int area = Int32.Parse(Console.ReadLine());
        if (goalType == 1)
        {
            SimpleGoal simple = new(name, description, points, area, false);
            _goalList.Add(simple);
        } else if (goalType == 2)
        {
            EternalGoal eternal = new(name, description, points, area);
            _goalList.Add(eternal);
        } else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int times = Int32.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = Int32.Parse(Console.ReadLine());
            ChecklistGoal checklist = new(name, description, points, area, bonusPoints, times, 0);
            _goalList.Add(checklist);
        }
    }
    public void ListGoals()
    {
        if (_goalList.Count() == 0)
        {
            Console.WriteLine("You don't have any goals yet.");
        } else
        {
            Console.WriteLine("The goals are:");
            int count = 0;
            foreach (Goal goal in _goalList)
            {
                // count is for numbering each goal listed
                count += 1;
                // check completeness to determine whether to put an X or a space
                string check;
                if (goal.GetCompleteness() == true)
                {
                    check = "X";
                } else
                {
                    check = " ";
                }
                // extra creativity: change console color based on the type of goal
                int area = goal.GetArea();
                if (area == 1)
                { //yellow/orange
                    Console.ForegroundColor = ConsoleColor.DarkYellow;                 
                } else if (area == 2)
                { //pink
                    Console.ForegroundColor = ConsoleColor.Magenta;
                } else if (area == 3)
                { //blue
                    Console.ForegroundColor = ConsoleColor.Cyan;
                } else if (area == 4)
                { //green
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                // List out the goal
                string goalInfo = goal.DisplayGoal();
                Console.WriteLine($"{count}. [{check}] {goalInfo}");
                // extra creativity: change console color back to default
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
    public void SaveGoals()
    {
        // ask user for file name
        Console.Write("What is the file name for the goal file? (use underscores for spaces and include .txt at the end) ");
        string filename = Console.ReadLine();
        // create new file
        using (StreamWriter outputFile = new(filename))
        {
            // first line is the point value
            outputFile.WriteLine(totalPoints);
            // all the other lines are the goal info
            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        // notify user that their file has been saved
        Console.WriteLine($"Your file has been saved under the name: {filename}");
    }
    public void LoadGoals()
    {
        // variables :
        Dictionary<string, string[]> infoDict = new();
        string name = "";
        string description = "";
        int points = 0;
        int area = 0;
        bool isComplete = false;
        int bonusPoints = 0;
        int times = 0;
        int timesComplete = 0;

        // ask user for file name
        Console.Write("What is the file name for the goal file you want to load? ");
        string filename = Console.ReadLine();
        // load the file
        string[] lines = System.IO.File.ReadAllLines(filename);
        int goalCount = lines.Count();
        // store the point value 
        totalPoints += Int32.Parse(lines[0]);
        // split the .txt file lines after the 1st one into 2 parts, ie. "Goal: [list of info about the goal]"
        for (int i = 1; i < goalCount; i ++)
        {
            string[] objectParts = lines[i].Split(":");
            string goalType = objectParts[0];
            string[] info = objectParts[1].Split("|");
            // add to dictionary
            infoDict.Add(goalType, info);
        }
        // define variables for the parts of the value in the dictionary
        // then create the goals and add them to the goals list
        foreach (KeyValuePair<string, string[]> kvp in infoDict)
        {
            name = kvp.Value[0];
            description = kvp.Value[1];
            points = Int32.Parse(kvp.Value[2]);
            area = Int32.Parse(kvp.Value[3]);
            if (kvp.Key == "SimpleGoal")
            {
                isComplete = bool.Parse(kvp.Value[4]);
                SimpleGoal simple = new(name, description, points, area, isComplete);
                _goalList.Add(simple);
            } else if (kvp.Key == "EternalGoal")
            {
                EternalGoal eternal = new(name, description, points, area);
                _goalList.Add(eternal);
            // Eternal Goals don't have any extra info in the string[]
             } else if (kvp.Key == "ChecklistGoal")
            {
                bonusPoints = Int32.Parse(kvp.Value[4]);
                times = Int32.Parse(kvp.Value[5]);
                timesComplete = Int32.Parse(kvp.Value[6]);
                ChecklistGoal checklist = new(name, description, points, area, bonusPoints, times,timesComplete);
                _goalList.Add(checklist);
            }
        }
        // // create the goals
        // foreach (KeyValuePair<string, string[]> kvp in infoDict)
        // {
        //     if (kvp.Key == "SimpleGoal")
        //     {
        //         SimpleGoal simple = new(name, description, points, area, isComplete);
        //         _goalList.Add(simple);
        //     } else if (kvp.Key == "EternalGoal")
        //     {
        //         EternalGoal eternal = new(name, description, points, area);
        //         _goalList.Add(eternal);
        //     }else if (kvp.Key == "ChecklistGoal")
        //     {
        //         ChecklistGoal checklist = new(name, description, points, area, bonusPoints, times,timesComplete);
        //         _goalList.Add(checklist);
        //     }
        // }
    }
    public void RecordEvent()
    {
        // List goals and ask which # goal was completed
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int accomplishedIndex = (Int32.Parse(Console.ReadLine()) - 1);
        // Set the completeness of that goal and tell user how many points they got
        _goalList[accomplishedIndex].SetCompleteness(true);
        int pointsEarned = _goalList[accomplishedIndex].GetPointValue();
        totalPoints += pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
    }
}