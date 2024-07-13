class Protein : FoodGroup
{
    // variables:

    // constructor:
    // public Protein(int servings) : base(servings)
    // {

    // }
    // methods:
    // public override void RecordFoodGroup(int servings)
    // {
    //     // add the amount of servings recorded to the consumed servings
    //     _consumedServings += servings;
    //     // if the new value of consumed servings is greater than the minimum, mark complete.
    //     if (_consumedServings >= _minServings)
    //     {
    //         _isComplete = true;
    //     }
    // }
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
/*maybe later you can figure out how to do little icons with the different food groups*/
        Console.WriteLine($"{_consumedServings}/{_minServings} oz. of protein, requirements {metness} for today.");
    }
    public override string GetStringRepresentation() //used for the save option in menu
    {
        return $"Protein:{_minServings}:{_consumedServings}";
    }

}