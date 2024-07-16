class Protein : FoodGroup
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
        Console.WriteLine($"{_consumedServings}/{_minServings} oz. of protein, requirements {metness} for today.");
    }
    public override int ExtraBonus()
    {
        Console.WriteLine("Did you eat a variety of proteins? Y/N");
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