class Grain : FoodGroup
{
    // variables:

    // constructor:
    // public Grain(int servings) : base(servings)
    // {

    // }
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
    public override string GetStringRepresentation() //used for the save option in menu
    {
        return $"Grain:{_minServings}:{_consumedServings}";
    }
}