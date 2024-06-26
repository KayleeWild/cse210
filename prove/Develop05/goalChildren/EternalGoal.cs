class EternalGoal : Goal
{
    // constructor:
    public EternalGoal(string name, string description, int points, int area) : base (name, description, points, area)
    {
        _isComplete = false;
    }
    // methods:
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name}|{_description}|{_pointValue}|{_growthArea}";
    }
    public override string DisplayGoal()
    {
        return $"{_name} ({_description})";
    }
    public override void SetCompleteness(bool isComplete)
    {
        // set it back to false because eternal goals are never complete
        isComplete = false;
        _isComplete = isComplete;
    }
    public override int GetPointValue()
    {
        return _pointValue;
    }
}