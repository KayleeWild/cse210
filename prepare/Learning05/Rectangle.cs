class Rectangle : Shape
{
    // variables
    private double _length;
    private double _width;
    // constructor
    public Rectangle(string color, double l, double w) : base(color)
    {
        _length = l;
        _width = w;
    }
    // method
    public override double GetArea()
    {
        return _length * _width;
    }
}