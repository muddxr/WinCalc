using Calculator.Core;

namespace Calculator.Winforms;

public partial class Form1 : Form
{
    private readonly CalculatorEngine _engine = new();

    public Form1()
    {
        InitializeComponent();
    }

    // One handler shared by all four operator buttons.
    // Each button stores its operator ("+", "-", "*", "/") in its Tag property.
    private void OperatorButton_Click(object? sender, EventArgs e)
    {
        if (!decimal.TryParse(txtFirst.Text, out var a) ||
            !decimal.TryParse(txtSecond.Text, out var b))
        {
            lblResult.Text = "Please enter two valid numbers.";
            return;
        }

        var op = (string)((Button)sender!).Tag!;

        try
        {
            lblResult.Text = $"= {_engine.Calculate(a, b, op)}";
        }
        catch (DivideByZeroException ex)
        {
            lblResult.Text = ex.Message;
        }
    }
}