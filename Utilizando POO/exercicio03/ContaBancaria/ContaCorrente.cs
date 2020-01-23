namespace ContaBancariaXUnitTest
{
    public class ContaCorrente : ContaBancaria
    {
        private readonly double _taxa = 0.5;
        public ContaCorrente(string numeroConta, double saldoInicial, double taxaOperacional) :
            base(numeroConta, saldoInicial)
        {
            _taxa = taxaOperacional;
        }

        public override void Depositar(double valor)
        {
            var taxaCalculada = valor * _taxa;
            var valorDeposito = valor - taxaCalculada;
            Saldo = Saldo + valorDeposito;
        }

        public override bool Sacar(double valor)
        {
            return true;
        }
    }
}