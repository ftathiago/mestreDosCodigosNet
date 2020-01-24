using System;

namespace Conta
{
    public abstract class ContaBancaria : IImprimivel
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
        public virtual void MostrarDados()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}");
            var saldo = String.Format("Saldo: {0:C2}", Saldo);
            Console.WriteLine(saldo);
        }
    }
}