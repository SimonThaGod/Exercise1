using System;
using Calculator;
using NUnit.Framework;
using DivideByZeroException = Calculator.DivideByZeroException;

namespace TestProject1;

public class Tests
{
    private Calculator.Calculator _uut;

    [SetUp]
    public void Setup()
    {
        _uut = new Calculator.Calculator();
    }

    /* --- Add --- */
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

    /* --- Subtract --- */
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

    /* --- Multiply --- */
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

    /* --- Division --- */

    [Test]
    public void Divide_Divisor0_DivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _uut.Divide(0));
    }

    /* --- Power --- */
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

    /* Accumulator */

    [Test]
    public void Accumulator_Initialized_0()
    {
        Assert.That(_uut.Accumulator, Is.EqualTo(0));
    }

    [Test]
    public void Clear_AccumulatorIs3_0()
    {
        // Arrange
        _uut.Add(3);

        // Act
        _uut.Clear();
        Assert.That(_uut.Accumulator, Is.EqualTo(0));
    }

    /* Accumulator - Add */
    [Test]
    public void AccumulatorAdd_AccBy3_3()
    {
        Assert.That(_uut.Add(3), Is.EqualTo(3));
        Assert.That(_uut.Accumulator, Is.EqualTo(3));
    }

    [Test]
    public void AccumulatorAdd_AccByNegative3_Negative3()
    {
        Assert.That(_uut.Add(-3), Is.EqualTo(-3));
        Assert.That(_uut.Accumulator, Is.EqualTo(-3));
    }

    [Test]
    public void AccumulatorAdd_Acc5By3_8()
    {
        // Arrange
        _uut.Add(5);

        // Act and Assert
        Assert.That(_uut.Add(3), Is.EqualTo(8));
        Assert.That(_uut.Accumulator, Is.EqualTo(8));
    }

    [Test]
    public void AccumulatorAdd_AccByMaxDoubleValue_AccumulatorOutOfRangeException()
    {
        // Arrange
        _uut.Add(1);

        // Act and Assert
        Assert.Throws<AccumulatorOutOfRangeException>(() => _uut.Add(Double.MaxValue));
        Assert.That(_uut.Accumulator, Is.EqualTo(1));
    }

    [Test]
    public void AccumulatorAdd_Acc4ByNegative5_Negative1()
    {
        // Arrange
        _uut.Add(4);

        // Act and Assert
        Assert.That(_uut.Subtract(5), Is.EqualTo(-1));
    }

    /* --- Subtract --- */
    [Test]
    public void AccumulatorSubtract_AccByMinDoubleValue_AccumulatorOutOfRangeException()
    {
        // Arrange
        _uut.Subtract(1);

        // Act and Assert
        Assert.Throws<AccumulatorOutOfRangeException>(() => _uut.Subtract(Double.MinValue));
        Assert.That(_uut.Accumulator, Is.EqualTo(-1));
    }

    [Test]
    public void AccumulatorSubtract_Acc4By1_3()
    {
        // Arrange
        _uut.Add(4);

        // Act and Assert
        Assert.That(_uut.Subtract(1), Is.EqualTo(3));
        Assert.That(_uut.Accumulator, Is.EqualTo(3));
    }

    [Test]
    public void AccumulatorSubtract_AccNegative1ByNegative1_2()
    {
        // Arrange
        _uut.Subtract(-1);

        // Act and Assert
        Assert.That(_uut.Subtract(-1), Is.EqualTo(2));
        Assert.That(_uut.Accumulator, Is.EqualTo(2));
    }

}
