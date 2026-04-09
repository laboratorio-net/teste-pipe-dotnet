namespace App.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new ();

    [Fact(DisplayName = "Deve somar dois numeros")]
    public void ShouldSumTwoNumbers()
    {        
        _calc.Sum(1, 2);
        Assert.Equal(3, _calc.Result);
    }

    [Fact(DisplayName = "Zero + Zero deve ser zero")]
    public void ZeroPlusZeroShouldBeZero()
    {        
        _calc.Sum(0, 0);
        Assert.Equal(0, _calc.Result);
    }

    [Fact(DisplayName = "Deve multiplicar multiplos números")]
    public void ShouldSumMultiplesNumbers()
    {        
        _calc.Sum(1, 2, 3, 4, 5);
        Assert.Equal(15, _calc.Result);
    }

    [Fact(DisplayName = "Deve subtrair dois números")]
    public void ShouldSubtractTwoNumbers()
    {        
        _calc.Subtract(2, 1);
        Assert.Equal(1, _calc.Result);
    }

    [Fact(DisplayName = "Subracao deve ter resultado zero quando dois numeros iguais")]
    public void ResultShouldBeZeroWhenSubtractTheSameNumers()
    {        
        _calc.Subtract(2, 2);
        Assert.Equal(0, _calc.Result);
    }
}
