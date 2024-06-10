class Activity
{
    // Variables:
    protected string _name;
    protected string _description;
    protected int _duration; // < < in seconds
    // Constructors:
    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _description = desc;
        _duration = duration;
    }
}