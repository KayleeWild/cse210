class SimpleGoal : Goal
{
    // constructor:
    public SimpleGoal(string name, string description, int points, int area, bool isComplete) : base (name, description, points, area)
    {
        _isComplete = isComplete;
    }
    // methods:
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name}|{_description}|{_pointValue}|{_growthArea}|{_isComplete}";
    }
    public override string DisplayGoal()
    {
        return $"{_name} ({_description})";
    }
    public override void SetCompleteness(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public override int GetPointValue()
    {
        return _pointValue;
    }
}
