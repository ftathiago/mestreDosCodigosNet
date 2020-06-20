using System;

namespace Conta
{
    public class ContaCorrente : ContaBancaria
    {
        private readonly decimal _taxaDeOperacoes;

        public ContaCorrente(string numeroConta, decimal saldoInicial, decimal taxaDeOperacoes) :
            base(numeroConta, saldoInicial)
        {
            _taxaDeOperacoes = taxaDeOperacoes;
        }

        public override void Depositar(decimal valor)
        {
            if (valor < 0)
                throw new ArgumentException("Não é possível fazer depósito negativo!");

            var taxaCalculada = valor * _taxaDeOperacoes;
            var valorDeposito = valor - taxaCalculada;
            Saldo += valorDeposito;
        }

        public override bool Sacar(decimal valor)
        {
            if (valor < 0)
                throw new ArgumentException("Não é possível fazer depósito negativo!");

            var taxaDeSaque = valor * _taxaDeOperacoes;
            var descontoTotal = valor + taxaDeSaque;
            var saldoFinal = Saldo - descontoTotal;

            if (saldoFinal < 0)
                return false;

            Saldo = saldoFinal;
            return true;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("======== Conta corrente ========");
            base.MostrarDados();
            var taxa = String.Format("Taxa: {0:F3}", _taxaDeOperacoes);
            Console.WriteLine(taxa);
        }
    }
}