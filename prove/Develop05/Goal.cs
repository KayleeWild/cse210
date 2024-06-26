class Goal 
{
    // variables:
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _isComplete;
    protected int _growthArea;// stretch <<< physical, spiritual, intellectual, social
    // constructor:
    public Goal(string name, string description, int points, int area)
    {
        _name = name;
        _description = description;
        _pointValue = points;
        _isComplete = false;
        _growthArea = area;
    }
    // methods:
    public int GetArea()
    {
        return _growthArea;
    }
    public bool GetCompleteness()
    {
        return _isComplete;
    }
    // virtual methods:
    public virtual string GetStringRepresentation()
    {
        return "NOTHING!! AHAHAHAHAHA";
    }
    public virtual string DisplayGoal()
    {
        return "NOTHING!! AHAHAHAHAHA";
    }
    public virtual void SetCompleteness(bool isComplete)
    {}
    public virtual int GetPointValue()
    {
        return 0;
    }
}