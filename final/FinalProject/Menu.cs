class Menu
{
    // variables:
    private string _filename = "food.txt";
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
    public void ListDailyRecord(FoodGroup[] foodGroups)
    {
        foreach (FoodGroup f in foodGroups)
        {
            f.DisplayRecord();
        }
    }
    public void SaveProgress(int streak, int badgeCount, FoodGroup[] foodList, int[] bonusList)
    {
        using (StreamWriter outputFile = new(_filename))
        {
            // First line is date saved
            outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
            // Second line is streak, third is number of badges earned
            outputFile.WriteLine($"{streak}\n{badgeCount}");
            // Next 5 lines are the serving requirements for each food group
            foreach (FoodGroup foodGroup in foodList)
            {
                outputFile.WriteLine(foodGroup.GetMinServings());
            }
            // Lines 9-13 are the consumed servings
            foreach (FoodGroup foodGroup in foodList)
            {
                outputFile.WriteLine(foodGroup.GetConsumedServings());
            }
            // Lines 14-16 keep track of whether the bonuses have been completed
            foreach (int bonus in bonusList)
            {
                outputFile.WriteLine(bonus);
            }
        }
    }
    public int[] LoadProgress(FoodGroup[] foodList)
    {
        // load the file into an array
        string[] lines = System.IO.File.ReadAllLines(_filename);
        string date = lines[0];
        int streak = Int32.Parse(lines[1]);
        int badgeCount = Int32.Parse(lines[2]);
        // set the min servings for each food group
        for (int i = 3; i < 8; i++ )
        {
            foodList[i-3].SetMinServings(Int32.Parse(lines[i]));
        }
        // if the file is from earlier today, load the consumed servings so far too. 
        if (DateTime.Now.ToString("MM/dd/yyyy") == date)
        {
           for (int i = 8; i < 13; i++)
            {
                foodList[i-8].SetConsumedServings(Int32.Parse(lines[i]));
            } 
        } else // otherwise the consumed servings are reset and the streak is increased.
        {
            streak ++;
            if (new int[] {2, 5, 10, 25, 50, 75, 100, 125, 150, 175, 200, 225, 250, 275, 300, 325, 365}.Contains(streak))
            {
                badgeCount ++;
            }
        }
        int fruitsAndVeggiesBonus = Int32.Parse(lines[13]);
        int grainBonus = Int32.Parse(lines[14]);
        int proteinBonus = Int32.Parse(lines[15]);
        return [streak, badgeCount, fruitsAndVeggiesBonus, grainBonus, proteinBonus];
    }
}