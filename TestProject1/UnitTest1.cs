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
    public void TestAdd()
    {
        Assert.That(_uut.Add(3, 3), Is.EqualTo(6));
    }

    [Test]
    public void TestAddDecimal()
    {
        Assert.That(_uut.Add(1.25,4.5),Is.EqualTo(5.75));
    }

    [Test]
    public void TestAddNegative()
    {
        Assert.That(_uut.Add(-5, 4), Is.EqualTo(-1));
    }

    [Test]
    public void TestSubtract()
    {
        Assert.That(_uut.Subtract(4, 3), Is.EqualTo(1));
    }

    [Test]
    public void TestSubtractDecimal()
    {
        Assert.That(_uut.Subtract(4.75, 3.5), Is.EqualTo(1.25));
    }

    [Test]
    public void TestSubtractNegative()
    {
        Assert.That(_uut.Subtract(4, -3), Is.EqualTo(7));
    }

    [Test]
    public void TestMultiply()
    {
        Assert.That(_uut.Multiply(2,3), Is.EqualTo(6));
    }

    public void TestMultiplyDecimal()
    {
        Assert.That(_uut.Multiply(2.5, 3.5), Is.EqualTo(8.75));
    }

    [Test]
    public void TestMultiplyNegative()
    {
        Assert.That(_uut.Multiply(-2, -4), Is.EqualTo(8));
    }

    [Test]
    public void TestPower()
    {
        Assert.That(_uut.Power(2, 3), Is.EqualTo(8));
    }

    [Test]
    public void TestPowerDecimal()
    {
        Assert.That(_uut.Power(2.5, 3), Is.EqualTo(15.625));
    }

    [Test]
    public void TestPowerNegative()
    {
        Assert.That(_uut.Power(2, -3), Is.EqualTo(0.125));
    }

    [Test]
    public void TestPowerZero()
    {
        Assert.That(_uut.Power(2, 0), Is.EqualTo(1));
    }
}