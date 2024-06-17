class Shape 
{
    // variable
    protected string _color;
    // constructor
    public Shape(string color)
    {
        SetColor(color);
    }
    // methods
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return 0;
    }
}