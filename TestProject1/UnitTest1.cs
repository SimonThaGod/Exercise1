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
    public void TestSubtract()
    {
        Assert.That(_uut.Subtract(3, 3), Is.EqualTo(0));
    }
}