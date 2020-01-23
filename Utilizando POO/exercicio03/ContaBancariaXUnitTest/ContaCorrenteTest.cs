using System;
using Xunit;

namespace ContaBancariaXUnitTest
{
    public class ContaCorrenteTest
    {
        private readonly double _taxaOperacional = 0.5;
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
        public void ShouldDepositTaxDeposit()
        {
            ContaBancaria contaCorrente = ContaCorrenteValida();
            var saldoAtual = contaCorrente.Saldo;
            var valorDeposito = 100;
            var saldoEsperado = (saldoAtual + valorDeposito) - (valorDeposito * _taxaOperacional);

            contaCorrente.Depositar(valorDeposito);

            Assert.Equal(saldoEsperado, contaCorrente.Saldo);
        }

        private ContaBancaria ContaCorrenteValida()
        {
            string numeroContaCorrente = "34035-0";
            double saldoInicial = 100;
            ContaBancaria contaCorrente = new ContaCorrente(numeroContaCorrente, saldoInicial, _taxaOperacional);
            return contaCorrente;
        }
    }
}
