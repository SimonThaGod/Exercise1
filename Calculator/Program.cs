// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Calculator.Calculator calc = new();

const double one = -12;
const double two = 3;

Console.WriteLine($"{one} * {two} = {calc.Multiply(one, two)}");
Console.WriteLine($"{one}^{two} = {calc.Power(one, two)}");
Console.WriteLine($"{one} + {two} = {calc.Add(one, two)}");
Console.WriteLine($"{one} - {two} = {calc.Subtract(one, two)}");
Console.WriteLine($"{one} / {two} = {calc.Divide(one, two)}");

calc.Add(10);
Console.WriteLine(calc.Accumulator);


Console.WriteLine(Double.MaxValue);
Console.WriteLine(Double.MaxValue+1);

calc.Add(Double.MaxValue + 1);
calc.Subtract(Double.MaxValue);
Console.WriteLine(calc.Accumulator);
Console.WriteLine(calc.Accumulator.GetType());
