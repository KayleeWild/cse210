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
            // "    4. Load Record\n" +
            "    4. Save and Quit\n" +
            "    5. Quit\n" +
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
    // public void SaveRecord(string filename, List<FoodGroup> foodGroups)
    // {
    //     using (StreamWriter outputFile = new(filename))
    //     {
    //         // first line is the streak?
    //         // outputFile.WriteLine(streak);
    //         // second line is the template
    //         outputFile.WriteLine("Food Group:servings requirement:amount eaten");
    //         // all the other lines are the food group info
    //         foreach (FoodGroup foodGroup in foodGroups)
    //         {
    //             outputFile.WriteLine(foodGroup.GetStringRepresentation());
    //         }
    //     }
    // }
    public void SaveProgress(string filename, int streak, int badgeIndex, FoodGroup[] foodList)
    {
        using (StreamWriter outputFile = new(filename))
        {
            // First line is streak, second is number of badges earned
            outputFile.WriteLine($"{streak}\n{badgeIndex}");
            // Next lines are the serving requirements for each food group
            foreach (FoodGroup foodGroup in foodList)
            {
                outputFile.WriteLine(foodGroup.GetMinServings());
            }
        }
    }
    public void LoadProgress(string filename, FoodGroup[] foodList)
    {
        // load the file
        string[] lines = System.IO.File.ReadAllLines(filename);
        int streak = Int32.Parse(lines[0]);
        int badgeIndex = Int32.Parse(lines[1]);
        // int fruitVegServings = Int32.Parse(lines[2]);
        // int grainServings = Int32.Parse(lines[3]);
        // int proteinServings = Int32.Parse(lines[4]);
        // int dairyServings = Int32.Parse(lines[5]);
        for (int i = 2; i < 7; i++ )
        {
            foodList[i-2].SetMinServings(Int32.Parse(lines[i]));
        }
        // foreach (string line in lines)
        // {
        //     string[] objectParts = line.Split(":");
        //     string foodGroup = objectParts[0];
        //     string minServings = objectParts[1];
        //     string consumedServings = objectParts[2];
        //     if (foodGroup == "Dairy")
        //     {
        //         Dairy myDairy = new(Int32.Parse(minServings));
        //         foodList.Add(myDairy);
        //         myDairy.RecordFoodGroup(Int32.Parse(consumedServings));
        //     } else if (foodGroup == "Fruit and Veggies")
        //     {
        //         FruitAndVeggies myFruitsVeg = new(Int32.Parse(minServings));
        //         foodList.Add(myFruitsVeg);
        //         myFruitsVeg.RecordFoodGroup(Int32.Parse(consumedServings));
        //     } else if (foodGroup == "Grain")
        //     {
        //         Grain myGrain = new(Int32.Parse(minServings));
        //         foodList.Add(myGrain);
        //         myGrain.RecordFoodGroup(Int32.Parse(consumedServings));
        //     } else if (foodGroup == "Protein")
        //     {
        //         Protein myProtein = new(Int32.Parse(minServings));
        //         foodList.Add(myProtein);
        //         myProtein.RecordFoodGroup(Int32.Parse(consumedServings));
        //     } else if (foodGroup == "Treats")
        //     {
        //         Treats myTreat = new(Int32.Parse(minServings));
        //         foodList.Add(myTreat);
        //         myTreat.RecordFoodGroup(Int32.Parse(consumedServings));
        //     }
        // }
    }
}