class Dairy : FoodGroup
{
    // variables:

    // constructor:
    // public Dairy(int servings) : base(servings)
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
        Console.WriteLine($"{_consumedServings}/{_minServings} cups of dairy, requirements {metness} for today.");
    }
    // public override string GetStringRepresentation() //used for the save option in menu
    // {
    //     return $"Dairy:{_minServings}:{_consumedServings}";
    // }
}