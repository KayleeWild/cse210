class Square : Shape
{
    // variable
    private double _side;
    // constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    // method
    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }

}