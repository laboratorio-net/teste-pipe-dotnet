namespace App.Tests;

public class CalculatorTests
{
    [Fact(DisplayName ="Deve somar dois numeros")]
    public void ShouldSumTwoNumbers()
    {
        var cal = new Calculator();
        cal.Sum(1, 2);

        Assert.Equal(3, cal.Result);
    }

    [Fact(DisplayName ="Zero + Zero deve ser zero")]
    public void ZeroPlusZeroShouldBeZero()
    {
        var cal = new Calculator();
        cal.Sum(0, 0);

        Assert.Equal(0, cal.Result);
    }
}
