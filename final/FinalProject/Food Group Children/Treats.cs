class Treats : FoodGroup
{
    // variables:

    // constructor:
    // public Treats(int servings) : base(servings)
    // {

    // }
    // methods:
    public override void RecordFoodGroup(int servings)
    {
        // add the amount of servings recorded to the consumed servings
        _consumedServings += servings;
        // if the new value of consumed servings is greater than the minimum, mark complete.
        if (_consumedServings > _minServings)
        {
            _isComplete = true;
        }
    }
    public override void DisplayRecord() //used for the list option in menu
    {
        string metness;
        if (_isComplete == false)
        {
            metness = "met";
        } else
        {
            metness = "not met";
        }
        Console.WriteLine($"{_consumedServings}/{_minServings} treats, goal {metness} for today.");
    }
    public override string GetStringRepresentation() //used for the save option in menu
    {
        return $"Treats:{_minServings}:{_consumedServings}";
    }
}