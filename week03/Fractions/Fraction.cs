using System.Runtime.Versioning;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(int top)
    {
        _numerator = top;
    }

    public void SetDenominator(int bottom)
    {
        _denominator = bottom;
    }

    public string GetFractionString()
    {
        // return $"{_numerator}/{_denominator}";
        // it's better for this method to access the getters instead of the member variables.
        // so when something goes wrong, it is contained within this class or method.
        return $"{GetNumerator()}/{GetDenominator()}";
    }
    public double GetDecimalValue()
    {
        return (double)GetNumerator()/GetDenominator();
    }
}