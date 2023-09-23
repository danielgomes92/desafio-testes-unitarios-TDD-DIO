namespace desafio_testes_unitarios_TDD_DIO
{
    public class Calculadora
    {
        private List<string> _historico = new List<string>();

        public int Soma(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            _historico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }

        public int Subtracao(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            _historico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }

        public int Multiplicacao(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            _historico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }

        public int Divisao(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            _historico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }

        public List<string> RetornaTresUltimosHistoricos()
        {
            _historico.RemoveRange(3, _historico.Count - 3);
            return _historico;
        }
    }
}
