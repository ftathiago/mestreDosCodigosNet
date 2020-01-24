using System;

namespace Conta
{
    public class ContaCorrente : ContaBancaria
    {
        private readonly double _taxaDeOperacoes;
        public ContaCorrente(string numeroConta, double saldoInicial, double taxaDeOperacoes) :
            base(numeroConta, saldoInicial)
        {
            _taxaDeOperacoes = taxaDeOperacoes;
        }

        public override void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Não é possível fazer depósito negativo!");

            var taxaCalculada = valor * _taxaDeOperacoes;
            var valorDeposito = valor - taxaCalculada;
            Saldo += valorDeposito;
        }

        public override bool Sacar(double valor)
        {
            var taxaDeSaque = valor * _taxaDeOperacoes;
            var descontoTotal = valor + taxaDeSaque;
            var saldoFinal = Saldo - descontoTotal;

            if (saldoFinal < 0)
                return false;

            Saldo = saldoFinal;
            return true;
        }
    }
}