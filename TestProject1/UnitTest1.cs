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
}