using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTestes  
{
    private CalculadoraImp _calc;
    
   
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

   
    [Fact]
    public void DeveSomar5Com10eRetornar15()
    {
        // metodologia TRIPLO A

        //arrange
        int num1 = 5;
        int num2 = 10;

        //act
        int resultado = _calc.somar(num1, num2);

        //assert
        Assert.Equal(15, resultado);
        
        //ARRANGE é o momento onde preparamos o codigo, montar o cenário, ou seja, somar 5 com 10. disponibilizar valores.
        //ACT Chamar a ação, nesse caso somar.
        //ASSERT Validar se retornou o resultado esperado.
    }

    
    [Fact]
    public void DeveSomar10Com10eRetornar20()
    {
        // metodologia TRIPLO A

        //arrange
        int num1 = 10;
        int num2 = 10;

        //act
        int resultado = _calc.somar(num1, num2);

        //assert
        Assert.Equal(20, resultado);
        
        //ARRANGE é o momento onde preparamos o codigo, montar o cenário, ou seja, somar 5 com 10. disponibilizar valores.
        //ACT Chamar a ação, nesse caso somar.
        //ASSERT Validar se retornou o resultado esperado.
    }

    [Fact]
    public void DeveReceber2eRetornarVerdadeiro()
    {
        int num = 2;

        bool ehPar = _calc.ehPar(num);
        Assert.True(ehPar);

    }


    [Theory]
    [InlineData(new int[] { 2, 4,})]
    [InlineData(new int[] { 6, 8})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Arrange

        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.ehPar(num)));
    }
   

} 