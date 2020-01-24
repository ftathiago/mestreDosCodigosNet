using System;

namespace Conta
{
    public class ContaEspecial : ContaBancaria
    {
        private readonly double _limite;
        public ContaEspecial(string numeroConta, double saldoInicial, double limite) :
            base(numeroConta, saldoInicial)
        {
            _limite = limite;
        }

        public override void Depositar(double valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Não é possível depósito negativo!");

            Saldo += valor;
        }

        public override bool Sacar(double valor)
        {
            var saldoParcial = Math.Abs(Saldo - valor);

            bool ultrapassouLimite = (Saldo <= valor) && (saldoParcial > _limite);
            if (ultrapassouLimite)
                return false;
            Saldo -= valor;
            return true;
        }
    }
}