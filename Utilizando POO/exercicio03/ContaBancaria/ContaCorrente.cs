namespace ContaBancariaXUnitTest
{
    public class ContaCorrente : ContaBancaria
    {
        private readonly double taxa = 0.5;
        public ContaCorrente(string numeroConta, double saldo) : base(numeroConta, saldo)
        {
        }

        public override void Depositar(double valor)
        {

        }

        public override bool Sacar(double valor)
        {
            return true;
        }
    }
}