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
    public void TestAddEquals()
    {
        Assert.That(_uut.Add(3, 3), Is.EqualTo(6));
    }

    [Test]
    public void TestAddGreaterThan()
    {
        Assert.That(_uut.Add(2,4),Is.GreaterThan(5));
    }

    [Test]
    public void TestSubtractEquals()
    {
        Assert.That(_uut.Subtract(3, 3), Is.EqualTo(0));
    }
}