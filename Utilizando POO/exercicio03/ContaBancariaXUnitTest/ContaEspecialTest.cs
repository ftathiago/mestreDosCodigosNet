using System;
using Conta;
using Xunit;

namespace Conta
{
    public class ContaEspecialTest
    {
        private const string _numeroConta = "0123456-x";
        private const double _saldoInicial = 100;
        private const double _limite = 100;

        [Fact]
        public void ShouldCreateContaEspecial()
        {
            ContaBancaria contaEspecial = new ContaEspecial(_numeroConta, _saldoInicial, _limite);

            Assert.NotNull(contaEspecial);
        }

        [Fact]
        public void ShouldDepositIncreaseAmount()
        {
            ContaBancaria contaEspecial = ContaEspecialValida();
            var valorDepositado = 100;
            var saldoEsperado = valorDepositado + _saldoInicial;
            contaEspecial.Depositar(valorDepositado);

            Assert.Equal(saldoEsperado, contaEspecial.Saldo);
        }

        [Fact]
        public void ShouldDepositBeAlwaysGreaterThanZero()
        {
            ContaBancaria contaEspecial = ContaEspecialValida();
            var valorDepositado = 0;

            Assert.Throws<ArgumentException>(() => contaEspecial.Depositar(valorDepositado));
        }

        [Fact]
        public void ShouldCashWithdraw()
        {
            //Given
            ContaBancaria contaEspecial = ContaEspecialValida();
            var valorSaque = 50;
            var saldoEsperado = _saldoInicial - valorSaque;

            //When
            var saqueOk = contaEspecial.Sacar(valorSaque);

            //Then
            Assert.True(saqueOk);
            Assert.Equal(saldoEsperado, contaEspecial.Saldo);
        }

        [Fact]
        public void ShouldAmountBeNegative()
        {
            ContaBancaria contaEspecial = ContaEspecialValida();
            var valorSaque = _saldoInicial + 1;
            var saldoEsperado = _saldoInicial - valorSaque;

            var saqueOk = contaEspecial.Sacar(valorSaque);

            Assert.True(saqueOk);
            Assert.Equal(saldoEsperado, contaEspecial.Saldo);
        }

        [Fact]
        public void ShouldNeverExceedLimit()
        {
            //Given
            ContaBancaria contaEspecial = ContaEspecialValida();
            var valorSaque = _saldoInicial - _limite - 1;
            var saldoEsperado = contaEspecial.Saldo;

            //When
            var saqueOk = contaEspecial.Sacar(valorSaque);

            //Then
            Assert.False(saqueOk);
            Assert.Equal(saldoEsperado, contaEspecial.Saldo);
        }

        private ContaEspecial ContaEspecialValida()
        {
            return new ContaEspecial(_numeroConta, _saldoInicial, _limite);
        }
    }
}