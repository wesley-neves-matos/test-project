using BaseProject;
namespace TestProject
{
    public class CalculadoraTests
    {
        private Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora();
        }

        [Theory]
        [InlineData(15, 3, 3, 4, 5)]
        [InlineData(12, 3, 2, 4, 1, 2)]
        public void SomarVariosValoresERetornarOValorCorreto(int resultadoEsperado, params int[] valoresSomar)
        {
            int resultadoObtido = _calculadora.Somar(valoresSomar);
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }


        [Theory]
        [InlineData(14, 20, 3, 1, 2)]
        [InlineData(16, 25, 2, 4, 1, 2)]
        public void SubtrairVariosValoresDeUmValorInicialERetornarOValorCorreto(int resultadoEsperado, int valorInicial, params int[] valoresSubtrair)
        {
            int resultadoObtido = _calculadora.Subtrair(valorInicial, valoresSubtrair);
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }

        [Theory]
        [InlineData(10, 20, 2)]
        [InlineData(60, 180, 3)]
        public void DividirUmValorPorOutroERetornarOValorCorreto(int resultadoEsperado, int valorADividir, int valorDivisor)
        {
            int resultadoObtido = _calculadora.Dividir(valorADividir, valorDivisor);
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }

        [Theory]
        [InlineData(360, 3, 3, 4, 5, 2)]
        [InlineData(24, 3, 2, 4, 1)]
        public void MultiplicarVariosValoresERetornarOValorCorreto(int resultadoEsperado, params int[] valoresMultiplicar)
        {
            int resultadoObtido = _calculadora.Multiplicar(valoresMultiplicar);
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }

        [Fact]
        public void TestarSeOHistoricoDaCalculadoraEhDiferenteDeNulo()
        {
            _calculadora.Somar(10, 12, 15, 22, 35);
            _calculadora.Multiplicar(5, 3, 2, 5, 4, 1);
            _calculadora.Subtrair(25, 2, 1, 1, 3, 5);

            Assert.NotNull(_calculadora.Historico);
        }
    }
}