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
            "    3. View Earned Badges\n" +
            "    4. How Do I Earn Badges?\n" +
            "    5. Save and Quit\n" +
            "    6. Quit\n" +
            "Select a choice from the menu: "
            );
    }
    // public void RecordFood(int food, int servings, FruitAndVeggies f, Grain g, Protein p, Dairy d, Treats t)
    // {
    //     if (food == 1)
    //     {
    //         f.RecordFoodGroup(servings);
    //     } else if (food == 2)
    //     {
    //         g.RecordFoodGroup(servings);
    //     } else if (food == 3)
    //     {
    //         p.RecordFoodGroup(servings);
    //     } else if (food == 4)
    //     {
    //         d.RecordFoodGroup(servings);
    //     } else if (food == 5)
    //     {
    //         t.RecordFoodGroup(servings);
    //     }
    // }
    public void ListDailyRecord(FoodGroup[] foodGroups)
    {
        foreach (FoodGroup f in foodGroups)
        {
            f.DisplayRecord();
        }
    }
    public void SaveProgress(string filename, int streak, int badgeIndex, FoodGroup[] foodList)
    {
        using (StreamWriter outputFile = new(filename))
        {
            // First line is date saved
            outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            // Second line is streak, third is number of badges earned
            outputFile.WriteLine($"{streak}\n{badgeIndex}");
            // Next lines are the serving requirements for each food group
            foreach (FoodGroup foodGroup in foodList)
            {
                outputFile.WriteLine(foodGroup.GetMinServings());
            }
            foreach (FoodGroup foodGroup in foodList)
            {
                outputFile.WriteLine(foodGroup.GetConsumedServings());
            }
        }
    }
    public int LoadProgress(string filename, FoodGroup[] foodList)
    {
        // load the file into an array
        string[] lines = System.IO.File.ReadAllLines(filename);
        string date = lines[0];
        int streak = Int32.Parse(lines[1]);
        int badgeIndex = Int32.Parse(lines[2]);
        // set the min servings for each food group
        for (int i = 3; i < 8; i++ )
        {
            foodList[i-3].SetMinServings(Int32.Parse(lines[i]));
        }
        // if the file is from earlier today, load the consumed servings so far too. 
        if (DateTime.Now.ToString("MM/dd/yyyy") == date)
        {
           for (int i = 8; i < 13; i++ )
            {
                foodList[i-8].SetConsumedServings(Int32.Parse(lines[i]));
            } 
        } else // otherwise the consumed servings are reset and the streak is increased.
        {
            streak ++;
        }
        return streak;
    }
}