class Grain : FoodGroup
{
    // methods:
    public override void DisplayRecord() //used for the list option in menu
    {
        string metness;
        if (_isComplete == true)
        {
            metness = "met";
        } else
        {
            metness = "not met";
        }
        Console.WriteLine($"{_consumedServings}/{_minServings} oz. of grains, requirements {metness} for today.");
    }
    public override int ExtraBonus()
    {
        Console.WriteLine("Think about the grains you ate today. Were at least half of them whole grains? Y/N");
        string answer = Console.ReadLine().ToUpper();
        if (answer == "Y")
        {
            return 1;
        } else 
        {
            return 0;
        }
    }
}