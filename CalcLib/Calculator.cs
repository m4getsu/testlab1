namespace CalcLib;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException();
        return a / b;
    }

    public bool IsEven(int n)
    {
        return n % 2 == 0;
    }
    
    public string? FindName(string[] names, string name)
    {
        foreach (var n in names)
        {
            if (n == name)
                return n;
        }
        return null;
    }
}
