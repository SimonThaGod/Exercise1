namespace Calculator;

public class Calculator
{
    public double Accumulator
    {
        get { return Accumulator; }
        private set
        {
            if (value > Double.MaxValue || value < Double.MinValue)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(value)} must not be lower than {Double.MinValue} and {Double.MaxValue}.");

            Accumulator = value;
        }
    }

    public double Add(double one, double two) => one + two;

    public double Subtract(double one, double two) => one - two;

    public double Multiply(double one, double two) => one * two;

    public double Power(double num, double exp) => Math.Pow(num, exp);

    public double Divide(double one, double two)
    {
        if (two == 0) throw new DivideByZeroException("You can't divide by zero!");
        
        return one / two;
    }

    public void Clear() => Accumulator = 0;

    public double Add(double one) => Accumulator += one;

    public double Subtract(double one) => Accumulator -= one;

    public double Multiply(double one) => Accumulator *= one;

    public double Power(double one) => Accumulator = Math.Pow(Accumulator, one);
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

public class AccumulatorOutOfRangeException : Exception
{
    public AccumulatorOutOfRangeException()
    {

    }

    public AccumulatorOutOfRangeException(string message) : base(message)
    {

    }
}