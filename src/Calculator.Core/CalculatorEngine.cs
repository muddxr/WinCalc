using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core;

public class CalculatorEngine
{
    public decimal Add(decimal a, decimal b) => a + b;

    public decimal Subtract(decimal a, decimal b) => a - b;

    public decimal Multiply(decimal a, decimal b) => a * b;

    public decimal Divide(decimal a, decimal b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return a / b;
    }

    // Lets the UI pass the operator from whichever button was clicked
    public decimal Calculate(decimal a, decimal b, string op) => op switch
    {
        "+" => Add(a, b),
        "-" => Subtract(a, b),
        "*" => Multiply(a, b),
        "/" => Divide(a, b),
        _ => throw new ArgumentException($"Unknown operator '{op}'.", nameof(op))
    };
}
