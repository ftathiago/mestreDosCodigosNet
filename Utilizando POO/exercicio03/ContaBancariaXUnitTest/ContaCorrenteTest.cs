using System;
using Xunit;
using Conta;

namespace ContaBancariaXUnitTest
{
    public class ContaCorrenteTest
    {
        private readonly double _taxaDeOperacoes = 0.5;
        private readonly double _saldoInicial = 100;
        [Fact]
        public void ShouldCreateContaCorrente()
        {
            string numeroContaCorrente = "34035-0";
            double saldoInicial = 100;
            double taxaOperacional = 0.5;
            ContaBancaria contaCorrente = new ContaCorrente(numeroContaCorrente, saldoInicial, taxaOperacional);

            Assert.NotNull(contaCorrente);
        }

        [Fact]
        public void ShouldDepositPaysCharges()
        {
            ContaBancaria contaCorrente = ContaCorrenteValida();
            var saldoAtual = contaCorrente.Saldo;
            var valorDeposito = 100;
            var saldoEsperado = (saldoAtual + valorDeposito) - (valorDeposito * _taxaDeOperacoes);

            contaCorrente.Depositar(valorDeposito);

            Assert.Equal(saldoEsperado, contaCorrente.Saldo);
        }

        [Fact]
        public void ShouldBeAlwaysPositiveDeposits()
        {
            ContaBancaria contaCorrente = ContaCorrenteValida();

            Assert.Throws<ArgumentException>(() => contaCorrente.Depositar(-1));
        }

        [Fact]
        public void ShouldCashWithdrawHasFeesDiscountedFromAmount()
        {
            ContaBancaria contaCorrente = ContaCorrenteValida();
            var valorSaque = 50;
            var saldoEsperado = 25;

            var saquePossivel = contaCorrente.Sacar(valorSaque);

            Assert.True(saquePossivel);
            Assert.Equal(saldoEsperado, contaCorrente.Saldo);
        }

        [Fact]
        public void ShouldAlwaysBePositive()
        {
            ContaBancaria contaCorrente = ContaCorrenteValida();
            var valorSaque = _saldoInicial + 0.01;
            var saldoEsperado = _saldoInicial;

            var saquePossivel = contaCorrente.Sacar(valorSaque);

            Assert.False(saquePossivel);
            Assert.Equal(saldoEsperado, contaCorrente.Saldo);
        }

        private ContaBancaria ContaCorrenteValida()
        {
            string numeroContaCorrente = "34035-0";
            ContaBancaria contaCorrente = new ContaCorrente(numeroContaCorrente, _saldoInicial, _taxaDeOperacoes);
            return contaCorrente;
        }
    }
}
