using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Calculator.Core;

namespace Calculator.Tests;

public class CalculatorEngineTests
{
    private readonly CalculatorEngine _calc = new();

    // [Fact] = one test case
    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var result = _calc.Add(2, 3);

        Assert.Equal(5m, result);
    }

    [Fact]
    public void Add_Decimals_IsExact()
    {
        Assert.Equal(0.3m, _calc.Add(0.1m, 0.2m));
    }

    // [Theory] + [InlineData] = same test, run once per data row
    [Theory]
    [InlineData(10, 4, 6)]
    [InlineData(0, 5, -5)]
    [InlineData(-3, -3, 0)]
    public void Subtract_ReturnsDifference(int a, int b, int expected)
    {
        Assert.Equal((decimal)expected, _calc.Subtract(a, b));
    }

    [Theory]
    [InlineData(3, 4, 12)]
    [InlineData(-2, 5, -10)]
    [InlineData(7, 0, 0)]
    public void Multiply_ReturnsProduct(int a, int b, int expected)
    {
        Assert.Equal((decimal)expected, _calc.Multiply(a, b));
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        Assert.Equal(2.5m, _calc.Divide(5, 2));
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(1, 0));
    }

    [Theory]
    [InlineData("+", 8)]
    [InlineData("-", 4)]
    [InlineData("*", 12)]
    [InlineData("/", 3)]
    public void Calculate_UsesCorrectOperator(string op, int expected)
    {
        Assert.Equal((decimal)expected, _calc.Calculate(6, 2, op));
    }

    [Fact]
    public void Calculate_UnknownOperator_Throws()
    {
        Assert.Throws<ArgumentException>(() => _calc.Calculate(1, 1, "%"));
    }
}