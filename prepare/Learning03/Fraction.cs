using System;

class Fraction {
    // Variables
    private int _top;
    private int _bottom;
    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    // Getters & Setters
    public int GetTop(){
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string altogether;
        if (_bottom > 1)
        {
            altogether = $"{_top}/{_bottom}";
        }
        else
        {
            altogether = _top.ToString();
        }
        return altogether;
    }
    public double GetDecimalValue()
    {
        double value = (double)_top / _bottom;
        return value;
    }
}