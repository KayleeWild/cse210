public class Assignment 
{
    // Variables:
    protected string _studentName;
    protected string _topic;
    // Constructor:
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    // Methods:
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}