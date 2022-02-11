namespace Calculator;

public class Calculator
{
    public double Add(double one, double two) => one + two;

    public double Subtract(double one, double two) => one - two;

    public double Multiply(double one, double two) => one * two;

    public double Power(double num, double exp) => Math.Pow(num, exp);

    public double Divide(double one, double two)
    {
        if (two == 0) throw new DivideByZeroException("You can't divide by zero!");
        
        return one / two;
    }
    
    
}

public class DivideByZeroException : Exception
{
    public DivideByZeroException()
    {
        
    }

    public DivideByZeroException(string message) : base(message)
    {
        
    }
}