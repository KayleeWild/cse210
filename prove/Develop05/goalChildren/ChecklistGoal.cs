class ChecklistGoal : Goal
{
    // variables:
    private int _bonusPoints;
    private int _times; // the number of times the goal must be completed to get bonus points
    private int _timesComplete; // the number of times the goal has been completed.
    // constructor:
    public ChecklistGoal(string name, string description, int points, int area, int bonusPoints, int times, int timesComplete) : base (name, description, points, area)
    {
        _bonusPoints = bonusPoints;
        _times = times;
        _timesComplete = timesComplete;
        if (_timesComplete >= _times)
        {
            _isComplete = true;
        } else
        {
            _isComplete = false;
        }
    }
    // methods:
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name}|{_description}|{_pointValue}|{_growthArea}|{_bonusPoints}|{_times}|{_timesComplete}";
    }
    public override string DisplayGoal()
    {
        return $"{_name} ({_description}) -- Currently completed: {_timesComplete}/{_times}";
    }
    public override void SetCompleteness(bool isComplete)
    {
        _timesComplete ++;
        // only set it as complete if it's been completed the right amount of times or more
        if (_timesComplete >= _times)
        {
            _isComplete = isComplete;
        }
    }
    public override int GetPointValue()
    {
        if (_isComplete == true)
        {
            return _pointValue + _bonusPoints;
        } else
        {
            return _pointValue;
        }
        
    }
}