using System;

class Program
{
    static void Main(string[] args)
    {
        Course course1 = new Course();
        course1._className = "Programming with Classes";
        course1._color = "green";
        course1._courseCode = "CSE 210";
        course1._numberOfCredits = 2;
        course1.Display();
    }
}