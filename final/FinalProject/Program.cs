using System;

class Program
{
    static void Main(string[] args)
    {
        // variables
        List<FoodGroup> _foodList = new();
        List<Badge> _badgeList = new(); //All the badges possible
        List<Badge> _userBadgeList = new(); //All the badges earned by the user
        int _streak = 0;

        // program:
        Console.Clear();
        Console.Write("Is this your first time using the app? (Y/N)");
        string response = Console.ReadLine().ToUpper();
        // Disclaimer
        if (response == "Y")
        {
            Console.WriteLine("* * *This application is to be used in conjunction with a pre-provided plan for daily food intake. Users can recieve information about this by talking with their health care provider, or educating themselves online at myplate.gov, and other resources.* * *");
            Console.WriteLine("\nTo use this application effectively, please visit https://www.myplate.gov/myplate-plan and determine the servings of each food group you'll need to aim for each day.\n1. Click the blue start button on the left side of the page.\n2. Enter your information\n3. Based on the recommended calories it returns, click the corresponding link in the table below. There you will find the serving sizes recommended for you.");
            Console.WriteLine("Press [Enter] when finished to proceed");
            Console.ReadLine();
        }
        // Ask for all the serving requrements needed
        Console.WriteLine("You will now enter in all your serving requirements. For each group, round your answer to the nearest cup or ounce, respectively.");
        Console.WriteLine("Add your fruit and veggie requirements and enter the total in cups: ");
        int fruitsveg = Int32.Parse(Console.ReadLine());
        FruitAndVeggies myFruitsVeg = new(fruitsveg);
        _foodList.Add(myFruitsVeg);

        Console.WriteLine("What is your grain requirement in ounces?");
        int grains = Int32.Parse(Console.ReadLine());
        Grain myGrain = new(grains);
        _foodList.Add(myGrain);
        
        Console.WriteLine("What is your protien requirement in ounces?");
        int protein = Int32.Parse(Console.ReadLine());
        Protein myProtein = new(protein);
        _foodList.Add(myProtein);
        
        Console.WriteLine("What is your dairy requirement in cups?");
        int dairy = Int32.Parse(Console.ReadLine());
        Dairy myDairy = new(dairy);
        _foodList.Add(myDairy);
        
        Console.WriteLine("Treats"); ////Write something about treats later
        int treat = Int32.Parse(Console.ReadLine());
        Treats myTreat = new(treat);
        _foodList.Add(myTreat);

        Console.Clear();
        Console.WriteLine("Thank you. Now please type in the number corresponding to your menu choice...");
        
        // menu loop
        Menu session = new();
        int menuOption = 0;
        while (menuOption != 6)
        {
            session.DisplayMenu();
            menuOption = Int32.Parse(Console.ReadLine());
            if (menuOption == 1)
            {
                Console.Clear();
                Console.Write(
                "What food group are you adding?\n" +
                "    1. Fruits/Veggies\n" +
                "    2. Grain\n" +
                "    3. Protein\n" +
                "    4. Dairy\n" +
                "    5. Treat\n" +
                "Type the corresponding number: "
                );
                int food = Int32.Parse(Console.ReadLine());
                Console.Write("How many servings did you eat? ");
                int servings = Int32.Parse(Console.ReadLine());
/* change the arguments/parameters to be the food list and iterate through it with a for each loop*/
                session.RecordFood(food, servings, myFruitsVeg, myGrain, myProtein, myDairy, myTreat);
                // if (food == 1)
                // {
                //     myFruitsVeg.RecordFoodGroup(servings);
                // } else if (food == 2)
                // {
                //     myGrain.RecordFoodGroup(servings);
                // } else if (food == 3)
                // {
                //     myProtein.RecordFoodGroup(servings);
                // } else if (food == 4)
                // {
                //     myDairy.RecordFoodGroup(servings);
                // } else if (food == 5)
                // {
                //     myTreat.RecordFoodGroup(servings);
                // }
                Console.Clear();
                Console.WriteLine("Food has been recorded!");
            } else if (menuOption == 2)
            {
                Console.Clear();
                session.ListDailyRecord(myFruitsVeg, myGrain, myProtein, myDairy, myTreat);
                Console.WriteLine();
            } else if (menuOption == 3)
            {
                Console.Clear();
                Console.Write("What is the name of the file you'd like your record saved under? (use underscores for spaces and include .txt at the end)");
                string filename = Console.ReadLine();
                session.SaveRecord(filename);
                Console.Clear();
                Console.WriteLine($"{filename} saved to local device!\n");
            } else if (menuOption == 4)
            {
                Console.Clear();
                Console.Write("What is the name of the file you'd like to load your record from? (make sure to include the .txt suffix)");
                string filename = Console.ReadLine();
                session.LoadRecord(filename);
                Console.Clear();
                Console.WriteLine($"{filename} loaded successfully!\n");
            } else if (menuOption == 5)
            {
                Console.Clear();
                Console.WriteLine("Here are the badges you've earned:");
                foreach (Badge badge in _userBadgeList)
                {
                    string badgeString = badge.GetBadge();
                    Console.WriteLine(badgeString);
                }
                Console.WriteLine("Earn more by increasing your streak or completing food group challenges.");
            }
        }
        Console.Write("Thanks for eating right! Have a happy day :)");
    }
}