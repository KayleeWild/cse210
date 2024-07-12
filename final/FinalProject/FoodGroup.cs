class FoodGroup
{
    // variables:
    protected int _minServings;
    protected int _consumedServings = 0;
    protected bool _isComplete = false;
    // constructor:
    public FoodGroup(int servings)
    {
        _minServings = servings;
    }
    public virtual void RecordFoodGroup(int servings)
    {
        // add the amount of servings recorded to the consumed servings
        _consumedServings += servings;
        // if the new value of consumed servings is greater than the minimum, mark complete.
        if (_consumedServings >= _minServings)
        {
            _isComplete = true;
        }
    }
    public virtual void DisplayRecord() //used for the list option in menu
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
        Console.WriteLine($"{_consumedServings}/{_minServings} food groups, requirements {metness} for today.");
    }
    public virtual void GetStringRepresentation() //used for the save option in menu
    {
        Console.WriteLine($"FoodGroup:{_minServings}:{_consumedServings}");
    }
}