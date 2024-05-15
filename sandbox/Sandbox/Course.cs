class Course
{
    public string _courseCode;
    public string _className;
    public int _numberOfCredits;
    public string _color;

    // method
    public void Display()
    {
        Console.Write($"{_courseCode} {_className} {_numberOfCredits} {_color}");
    }
}