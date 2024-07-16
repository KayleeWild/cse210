using System;

class Program
{
    static void Main(string[] args)
    {
        // variables:
        int _badgeCount = 0; // All numbers up to this index in the badge gallery have been earned by the user.
        int _streak = 0;
        int _fruitsAndVeggiesBonus = 0;
        int _proteinBonus = 0;
        int _grainBonus = 0;
        Menu session = new();
        FruitAndVeggies myFruitsVeg = new();
        Grain myGrain = new();
        Protein myProtein = new();
        Dairy myDairy = new();
        Treats myTreat = new();
        FoodGroup[] _foodList = [myFruitsVeg, myGrain, myProtein, myDairy, myTreat];
        BadgeGallery gallery = new();


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
            // Ask for all the serving requrements needed
            Console.WriteLine("You will now enter in all your serving requirements. For each group, round your answer to the nearest cup or ounce, respectively.");
            // Fruits and Veggies:
            Console.WriteLine("Add your fruit and veggie requirements and enter the total in cups: ");
            int fruitsveg = Int32.Parse(Console.ReadLine());
            myFruitsVeg.SetMinServings(fruitsveg);
            // Grains:
            Console.WriteLine("What is your grain requirement in ounces?");
            int grains = Int32.Parse(Console.ReadLine());
            myGrain.SetMinServings(grains);
            // Protien:
            Console.WriteLine("What is your protien requirement in ounces?");
            int protein = Int32.Parse(Console.ReadLine());
            myProtein.SetMinServings(protein);
            // Dairy:
            Console.WriteLine("What is your dairy requirement in cups?");
            int dairy = Int32.Parse(Console.ReadLine());
            myDairy.SetMinServings(dairy);
            // Treats:
            Console.WriteLine("Treats tend to have few nutrients, and should only be enjoyed occasionally. What is the maximum amount of treats you'd like to limit yourself to each day?"); 
            int treat = Int32.Parse(Console.ReadLine());
            myTreat.SetMinServings(treat);
        } else if (response == "N")
        {
            Console.Clear();
            // Console.WriteLine("What is the name of the file you'd like to load your record from? (make sure to include the .txt suffix)");
            // string filename = Console.ReadLine();
            int[] results = session.LoadProgress(_foodList);
            _streak = results[0];
            _badgeCount = results[1];
            _fruitsAndVeggiesBonus = results[2];
            _grainBonus = results[3];
            _proteinBonus = results[4];
            Console.Clear();
            Console.WriteLine($"File loaded successfully!\n");
        }
         // menu loop
        Console.Clear();
        Console.WriteLine("Thank you. Now please type in the number corresponding to your menu choice...");
        int menuOption = 0;
        do {
            Console.WriteLine($"Your overall streak is: {_streak} days!");
            session.DisplayMenu();
            menuOption = Int32.Parse(Console.ReadLine());
            if (menuOption == 1)
            {
                // display options for food groups
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
                // ask user how many servings they ate and store in object depending on answer to previous prompt
                Console.Write("How many servings did you eat? ");
                int servings = Int32.Parse(Console.ReadLine());
                Console.Clear();
                if (food == 1)
                {
                    myFruitsVeg.RecordFoodGroup(servings);
                    if (_fruitsAndVeggiesBonus == 0)
                    {
                        _fruitsAndVeggiesBonus = myFruitsVeg.ExtraBonus();
                        _badgeCount ++;
                    } else 
                    {
                        Console.WriteLine("Bonus fruits and veggies badge has already been earned, but please continue to strive for half your plate to be fruits or veggies.");
                    }
                } else if (food == 2)
                {
                    myGrain.RecordFoodGroup(servings);
                    if (_grainBonus == 0)
                    {
                        _grainBonus = myGrain.ExtraBonus();
                        _badgeCount ++;
                    } else 
                    {
                        Console.WriteLine("Bonus grain badge has already been earned, but please continue to strive for at least half your grains to be whole grains.");
                    }
                } else if (food == 3)
                {
                    myProtein.RecordFoodGroup(servings);
                    if (_proteinBonus == 0)
                    {
                        _proteinBonus = myProtein.ExtraBonus();
                        _badgeCount ++;
                    } else 
                    {
                        Console.WriteLine("Bonus protein badge has already been earned, but please continue to eat a good variety of protein.");
                    }
                    
                } else if (food == 4)
                {
                    myDairy.RecordFoodGroup(servings);
                } else if (food == 5)
                {
                    myTreat.RecordFoodGroup(servings);
                }
                // success message
                Console.WriteLine("Food has been recorded!");
            } else if (menuOption == 2)
            {
                // Display the day's progress
                Console.Clear();
                Console.WriteLine("Today's Progress:");
                session.ListDailyRecord(_foodList);
                Console.WriteLine();
            } else if (menuOption == 3)
            {
                // Display all badges user has ever earned
                Console.Clear();
                Console.WriteLine("Here are the badges you've earned:");
                string stringy = new string('-', Console.WindowWidth);
                string[] wholeList = gallery.GetBadgesList();
                int count = 0;
                for (int i = 1; i <= _badgeCount; i++)
                {
                    Console.WriteLine(stringy);
                    Console.WriteLine($"Badge #{i}:\n");
                    Console.WriteLine(wholeList[i - 1]);
                    Console.WriteLine();
                    count ++;
                }
                Console.WriteLine(stringy);
                Console.WriteLine($"\nYou have earned {count} badges!\n");
                Console.WriteLine("Earn more by increasing your streak, meeting goals, or completing food group challenges.");
            } else if (menuOption == 4)
            {
                Console.Clear();
                string stringy = new string('-', Console.WindowWidth);
                Console.WriteLine("How do I earn more badges?");
                Console.WriteLine(stringy);
                Console.WriteLine("1. Streaks.\nStreaks are built by coming back and logging your food often. Each new day that you come back to log your food, your streak increases by one. As you reach milestones of " + 
                "2, 5, 10, 25, 50, and 100 days, you will be awarded new badges. Streaks will not reset if you miss a day. They simply keep track of your total days logged.");
                Console.WriteLine("2. Make half your plate fruits and veggies.\nThe first time you lot fruits and veggies as half of your plate, you will earn a badge. *");
                Console.WriteLine("3. Make half your grains whole grains.\nThe first time you log that at least half your grains were whole grains, you will earn a badge. *");
                Console.WriteLine("4. Eat a variety of protein.\nThe first time you log proteins that you determine to be of a good variety, you will earn a badge. *");
                Console.WriteLine("5. Meet your goals!\nEach time you meet all your requirements/goals in a food group, you get closer to earning another badge. The milestones for this method are " +
                "5, 10, 15, 20, and 25 goals met.");
                Console.WriteLine("\n(Badges marked with a * can only be earned once, but it is still recommended to follow the guidelines recommended in them for better overall health.)");
            }
        } while (new int[] {1, 2, 3, 4}.Contains(menuOption));
        Console.Clear();
        if (menuOption == 5)
            {
                Console.Clear();
                // Console.WriteLine("What is the name of the file you'd like your progress saved under? (use underscores for spaces and include .txt at the end)");
                // string filename = Console.ReadLine();
                int[] _bonusList = [_fruitsAndVeggiesBonus, _grainBonus, _proteinBonus];
                session.SaveProgress(_streak, _badgeCount, _foodList, _bonusList);
                Console.Clear();
                Console.WriteLine($"File saved to local device!\n");
            }
        Console.Write("Thanks for eating right! Have a happy day :)");
    }
}