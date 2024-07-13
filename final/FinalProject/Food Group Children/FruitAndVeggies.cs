class FruitAndVeggies : FoodGroup
{
    // variables:

    // constructor:
    // public FruitAndVeggies(int servings) : base(servings)
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
        Console.WriteLine($"{_consumedServings}/{_minServings} cups of fruits and/or veggies, requirements {metness} for today.");
    }
    // public override string GetStringRepresentation() //used for the save option in menu
    // {
    //     return $"Fruit and Veggies:{_minServings}:{_consumedServings}";
    // }
}