class Circle : Shape
{
    // variables
    private double _radius;
    // constructor
    public Circle(string color, double r) : base(color)
    {
        _radius = r;
    }
    // method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}