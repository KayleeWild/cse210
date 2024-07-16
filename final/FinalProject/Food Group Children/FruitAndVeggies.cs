class FruitAndVeggies : FoodGroup
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
        Console.WriteLine($"{_consumedServings}/{_minServings} cups of fruits and/or veggies, requirements {metness} for today.");
    }
    public override int ExtraBonus()
    {
        Console.WriteLine("Did you make at least half of your plate fruits/veggies? Y/N");
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