using System;
using System.Collections.Generic;
using System.IO;

public class Fraction
{
    // Private attributes for encapsulation
    private int _top;
    private int _bottom;

    // Constructor 1: Default - sets fraction to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor 2: Takes one number and makes it top / 1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor 3: Takes top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for top (numerator)
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for bottom (denominator)
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return fraction as string, like "3/4"
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // Return decimal value, like 0.75
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
