using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Calculator.Api.Tests;

public class CalculateEndpointTests(WebApplicationFactory<Program> factory)
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Theory]
    [InlineData("add", 10, 4, 14)]
    [InlineData("subtract", 10, 4, 6)]
    [InlineData("multiply", 10, 4, 40)]
    [InlineData("divide", 10, 4, 2.5)]
    public async Task Calculate_ValidOperation_ReturnsResult(string op, int a, int b, double expected)
    {
        var response = await _client.GetAsync($"/calculate?a={a}&b={b}&op={op}");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var body = await response.Content.ReadFromJsonAsync<CalculationResponse>();
        Assert.NotNull(body);
        Assert.Equal((decimal)expected, body.Result);
        Assert.Equal(op, body.Op);
    }

    [Theory]
    [InlineData("/calculate?a=10&b=0&op=divide")]   // divide by zero
    [InlineData("/calculate?a=10&b=4&op=power")]    // unknown operation
    [InlineData("/calculate?a=10&op=add")]          // missing b
    [InlineData("/calculate?a=abc&b=4&op=add")]     // not a number
    public async Task Calculate_InvalidRequest_ReturnsBadRequest(string url)
    {
        var response = await _client.GetAsync(url);

        Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }

    [Fact]
    public async Task Health_ReturnsHealthy()
    {
        var response = await _client.GetAsync("/health");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("Healthy", await response.Content.ReadAsStringAsync());
    }

    private sealed record CalculationResponse(decimal A, decimal B, string Op, decimal Result);
}