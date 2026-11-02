using Calculator.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CalculatorEngine>();
builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapGet("/calculate", (decimal a, decimal b, string op, CalculatorEngine engine) =>
{
    var symbol = op.ToLowerInvariant() switch
    {
        "add" => "+",
        "subtract" => "-",
        "multiply" => "*",
        "divide" => "/",
        _ => null
    };

    if (symbol is null)
    {
        return Results.Problem(
            title: $"Unknown operation '{op}'. Use add, subtract, multiply or divide.",
            statusCode: StatusCodes.Status400BadRequest);
    }

    try
    {
        var result = engine.Calculate(a, b, symbol);
        return Results.Ok(new CalculationResponse(a, b, op, result));
    }
    catch (Exception ex) when (ex is DivideByZeroException or OverflowException)
    {
        return Results.Problem(title: ex.Message, statusCode: StatusCodes.Status400BadRequest);
    }
});

app.MapHealthChecks("/health");

app.Run();

internal record CalculationResponse(decimal A, decimal B, string Op, decimal Result);

public partial class Program { } // for integration tests