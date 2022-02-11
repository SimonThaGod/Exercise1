namespace Calculator;

public class Calculator
{
    private double _accumulator = 0;
    public double Accumulator
    {
        get { return _accumulator; }
        private set
        {
            if (value >= Double.MaxValue || value <= Double.MinValue)
                throw new AccumulatorOutOfRangeException(
                    $"{nameof(value)} must not be lower than {Double.MinValue} and greater than {Double.MaxValue}.");

            _accumulator = value;
        }
    }

    public double Add(double one, double two) => one + two;

    public double Subtract(double one, double two) => one - two;

    public double Multiply(double one, double two) => one * two;

    public double Power(double num, double exp)
    {
        if (num < 0 && exp != Math.Round(exp))
            throw new NegativePowerByNonIntegerException();
        return Math.Pow(num, exp);
    }

    public double Divide(double one, double two)
    {
        if (two == 0) throw new DivideByZeroException();
        
        return one / two;
    }

    public void Clear() => Accumulator = 0;

    public double Add(double one) => Accumulator += one;

    public double Subtract(double one) => Accumulator -= one;

    public double Multiply(double one) => Accumulator *= one;

    public double Power(double one)
    {
        if (Accumulator < 0 && one != Math.Round(one))
            throw new NegativePowerByNonIntegerException();

        Accumulator = Math.Pow(Accumulator, one);
        return Accumulator;
    }

public double Divide(double divisor) => 
        Accumulator = divisor != 0 ? Accumulator / divisor : throw new DivideByZeroException();
}

public class DivideByZeroException : Exception
{
    public DivideByZeroException(string message = "You can't divide by zero!") : base(message)
    {
        
    }
}

public class AccumulatorOutOfRangeException : Exception
{
    public AccumulatorOutOfRangeException(string message) : base(message)
    {

    }
}

public class NegativePowerByNonIntegerException : Exception
{
    public NegativePowerByNonIntegerException(string message = "Can't power negative with non-integer exponent") : base(message)
    {

    }
}