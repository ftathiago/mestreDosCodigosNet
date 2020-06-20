using System;

namespace Conta
{
    public abstract class ContaBancaria : IImprimivel
    {
        public string NumeroConta { get; private set; }
        public decimal Saldo { get; protected set; }

        public ContaBancaria(string numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public abstract void Depositar(decimal valor);
        public abstract bool Sacar(decimal valor);

        public virtual void MostrarDados()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}");
            var saldo = String.Format("Saldo: {0:C}", Saldo);
            Console.WriteLine(saldo);
        }
    }
}