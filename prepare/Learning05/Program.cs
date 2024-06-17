using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        // Square squarey = new("purple", 2.5);
        shapes.Add(new Square("purple", 2.5));
        shapes.Add(new Rectangle("orange", 2, 6));
        shapes.Add(new Circle("red", 3));
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Your {color} shape has an area of {area}.");
        }
    }
}