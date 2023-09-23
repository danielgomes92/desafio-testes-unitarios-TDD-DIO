using desafio_testes_unitarios_TDD_DIO;

namespace teste_desafio_testes_unitarios_TDD_DIO
{
    public class CalculadoraTestes
    {
        private Calculadora _calc;

        public CalculadoraTestes()
        {
            _calc = new Calculadora();
        }

        [Fact]
        public void TesteSomar()
        {
            int num1 = 1;
            int num2 = 2;

            int resultado = _calc.Soma(num1, num2);

            Assert.Equal(3, resultado);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(9, 5, 4)]
        public void TesteSubtracao(int numero1, int numero2, int resultado)
        {
            int resultadoCalculadora = _calc.Subtracao(numero1, numero2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(3, 3, 9)]
        public void TesteMultiplicacao(int numero1, int numero2, int resultado)
        {
            int resultadoCalculadora = _calc.Multiplicacao(numero1, numero2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDivisao(int numero1, int numero2, int resultado)
        {
            int resultadoCalculadora = _calc.Divisao(numero1, numero2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            Assert.Throws<DivideByZeroException>(
                () => _calc.Divisao(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            _calc.Soma(1, 2);
            _calc.Soma(2, 8);
            _calc.Soma(4, 7);
            _calc.Soma(4, 1);
            _calc.Soma(7, 7);

            var lista = _calc.RetornaTresUltimosHistoricos();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}