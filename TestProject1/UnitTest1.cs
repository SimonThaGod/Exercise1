using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    private Calculator.Calculator _uut;
    [SetUp]
    public void Setup()
    {
        _uut = new Calculator.Calculator();
    }

    [Test]
    public void Add_3by3_6()
    {
        Assert.That(_uut.Add(3, 3), Is.EqualTo(6));
    }

    [Test]
    public void Add_Decimals_Decimal()
    {
        Assert.That(_uut.Add(1.25,4.5),Is.EqualTo(5.75));
    }

    [Test]
    public void Add_Negative5byPositive4_Negative1()
    {
        Assert.That(_uut.Add(-5, 4), Is.EqualTo(-1));
    }

    [Test]
    public void Subtract_4by3_1()
    {
        Assert.That(_uut.Subtract(4, 3), Is.EqualTo(1));
    }

    [Test]
    public void Subtract_Decimals_Decimal()
    {
        Assert.That(_uut.Subtract(4.75, 3.5), Is.EqualTo(1.25));
    }

    [Test]
    public void Subtract_Positive4byNegative3_7()
    {
        Assert.That(_uut.Subtract(4, -3), Is.EqualTo(7));
    }

    [Test]
    public void Multiply_2by3_6()
    {
        Assert.That(_uut.Multiply(2,3), Is.EqualTo(6));
    }

    public void Multiply_Decimals_Decimal()
    {
        Assert.That(_uut.Multiply(2.5, 3.5), Is.EqualTo(8.75));
    }

    [Test]
    public void Multiply_Negative2byNegative4_8()
    {
        Assert.That(_uut.Multiply(-2, -4), Is.EqualTo(8));
    }

    [Test]
    public void Power_2by3_8()
    {
        Assert.That(_uut.Power(2, 3), Is.EqualTo(8));
    }

    [Test]
    public void Power_DecimalIn3_Decimal()
    {
        Assert.That(_uut.Power(2.5, 3), Is.EqualTo(15.625));
    }

    [Test]
    public void Power_Positive2InNegative3_Decimal()
    {
        Assert.That(_uut.Power(2, -3), Is.EqualTo(0.125));
    }

    [Test]
    public void Power_Positive2by0_1()
    {
        Assert.That(_uut.Power(2, 0), Is.EqualTo(1));
    }
}