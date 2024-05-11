using Calculadora.services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    [Fact]
    public void TesteSomar()
    {
        CalculadoraImp c = new CalculadoraImp();

        int resultado = c.Somar(1,2);

        Assert.Equal(3,resultado);
    }

    [Fact]
    public void TesteMultiplicar()
    {
        CalculadoraImp c = new CalculadoraImp();

        int resultado = c.Multiplicar(2,2);

        Assert.Equal(4,resultado);
    }
    [Fact]
    public void TesteDividir()
    {
        CalculadoraImp c = new CalculadoraImp();

        int resultado = c.Dividir(6,2);

        Assert.Equal(3,resultado);
    }
    [Fact]
    public void TesteDividirPor0()
    {
        CalculadoraImp c = new CalculadoraImp();

        Assert.Throws<Exception>(
            () => c.Dividir(3,0)
        );
    }

    [Fact]
    public void TesteHistorico()
    {
        CalculadoraImp c = new CalculadoraImp();
        c.Somar(1,2);
        c.Somar(3,4);
        c.Somar(5,6);
        c.Somar(7,8);

        var lista = c.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);   
    }
}