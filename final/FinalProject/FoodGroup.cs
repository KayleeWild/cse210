class FoodGroup
{
    // variables:
    protected int _minServings = 0;
    protected int _consumedServings = 0;
    protected bool _isComplete = false;
    // constructor:
    // public FoodGroup(int servings)
    // {
    //     _minServings = servings;
    // }
    public void SetMinServings(int servings)
    {
        _minServings = servings;
    }
    public int GetMinServings()
    {
        return _minServings;
    }
    public void SetConsumedServings(int servings)
    {
        _consumedServings = servings;
    }
    public int GetConsumedServings()
    {
        return _consumedServings;
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
    // public virtual string GetStringRepresentation() //used for the save option in menu
    // {
    //     return $"FoodGroup:{_minServings}:{_consumedServings}";
    // }
}