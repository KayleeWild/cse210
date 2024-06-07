public class MathAssignment : Assignment
{
    // Variables:
    private string _textbookSection;
    private string _problems;
    // Constructor:
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }
    // Method:
    public string GetHomeworkList() 
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}