using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10Retornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(15, resultado);
    }
     [Fact]
    public void DeveSomar10Com10Retornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(20, resultado);
    }
}