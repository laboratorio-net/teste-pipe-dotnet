namespace App.Tests;

public class CalculatorTests
{
    [Fact(DisplayName = "Deve somar dois numeros")]
    public void ShouldSumTwoNumbers()
    {
        var cal = new Calculator();
        cal.Sum(1, 2);

        Assert.Equal(3, cal.Result);
    }

    [Fact(DisplayName = "Zero + Zero deve ser zero")]
    public void ZeroPlusZeroShouldBeZero()
    {
        var cal = new Calculator();
        cal.Sum(0, 0);

        Assert.Equal(0, cal.Result);
    }

    [Fact(DisplayName = "Deve subtrair dois números")]
    public void ShouldSubtractTwoNumbers()
    {
        var cal = new Calculator();
        cal.Subtract(2, 1);

        Assert.Equal(1, cal.Result);
    }

    [Fact(DisplayName = "Subracao deve ter resultado zero quando dois numeros iguais")]
    public void ResultShouldBeZeroWhenSubtractTheSameNumers()
    {
        var cal = new Calculator();
        cal.Subtract(2, 2);

        Assert.Equal(0, cal.Result);
    }
}
