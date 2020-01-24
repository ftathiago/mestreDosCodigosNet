namespace Conta
{
    public abstract class ContaBancaria
    {
        public string NumeroConta { get; private set; }
        public double Saldo { get; protected set; }

        public ContaBancaria(string numeroConta, double saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public abstract void Depositar(double valor);
        public abstract bool Sacar(double valor);
    }
}