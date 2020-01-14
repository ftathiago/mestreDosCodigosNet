namespace exercicio01
{
    public class OperacaoMatematica
    {
        private int _valorA;
        private int _valorB;

        public OperacaoMatematica(int valorA, int valorB)
        {
            _valorA = valorA;
            _valorB = valorB;
        }

        public int Somar() => _valorA + _valorB;
        public int Multiplicar() => _valorA * _valorB;
        public int Subtrair() => _valorA - _valorB;
        public decimal Dividir() => _valorA / _valorB;
    }
}