class FoodGroup
{
    // variables:
    protected int _minServings;
    protected int _consumedServings;
    protected bool _isComplete;
    // constructor:
    public FoodGroup(int servings)
    {
        _minServings = servings;
        _consumedServings = 0;
        _isComplete = false;
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
    public virtual void DisplayRecord()
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
    public virtual void GetStringRepresentation()
    {
        Console.WriteLine($"FoodGroup:{_consumedServings}");
    }
}