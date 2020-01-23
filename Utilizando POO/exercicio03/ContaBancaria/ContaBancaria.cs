namespace ContaBancariaXUnitTest
{
    public abstract class ContaBancaria
    {
        public string NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public abstract void Depositar(double valor);
        public abstract bool Sacar(double valor);
    }
}