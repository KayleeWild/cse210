class Menu
{
    // variables:
    
    // methods:
    public void DisplayMenu()
    {
        Console.Write(
            "\nMenu Options:\n" +
            "    1. Record Food\n" +
            "    2. List Daily Record\n" +
            "    3. Save Record\n" +
            "    4. Load Record\n" +
            "    5. View Badges Earned\n" +
            "    6. Quit\n" +
            "Select a choice from the menu: "
            );
    }
    public void RecordFood(int food, int servings, FruitAndVeggies f, Grain g, Protein p, Dairy d, Treats t)
    {
        if (food == 1)
        {
            f.RecordFoodGroup(servings);
        } else if (food == 2)
        {
            g.RecordFoodGroup(servings);
        } else if (food == 3)
        {
            p.RecordFoodGroup(servings);
        } else if (food == 4)
        {
            d.RecordFoodGroup(servings);
        } else if (food == 5)
        {
            t.RecordFoodGroup(servings);
        }
    }
    public void ListDailyRecord(FruitAndVeggies f, Grain g, Protein p, Dairy d, Treats t)
    {
        f.DisplayRecord();
        g.DisplayRecord();
        p.DisplayRecord();
        d.DisplayRecord();
        t.DisplayRecord();
    }
    public void SaveRecord(string filename)
    {
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
    }
    public void LoadRecord(string filename)
    {
        /*Do the load thing*/
    }
}