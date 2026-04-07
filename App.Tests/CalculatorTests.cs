namespace App.Tests;

public class CalculatorTests
{
    [Fact]
    public void ShouldSumTwoNumbers()
    {
        var cal = new Calculator();
        cal.Sum(1, 2);

        Assert.Equal(3, cal.Result);
    }
}
