namespace Conta
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria contaCorrente = new ContaCorrente("001-x", 100, 0.05M);
            contaCorrente.MostrarDados();
            contaCorrente.Depositar(100);
            contaCorrente.Sacar(50);
            contaCorrente.Sacar(1000);
            contaCorrente.MostrarDados();

            ContaBancaria contaEspecial = new ContaEspecial("002-x", 100, 100);
            contaEspecial.MostrarDados();
            contaEspecial.Depositar(100);
            contaEspecial.Sacar(210);
            contaEspecial.MostrarDados();
            contaEspecial.Sacar(300);
            contaEspecial.MostrarDados();
        }
    }
}
