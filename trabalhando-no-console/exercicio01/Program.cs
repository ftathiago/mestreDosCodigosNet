using System;

namespace exercicio01
{
    class Program
    {
        static int PegarValor(string mensagem)
        {
            Console.WriteLine(mensagem);
            string entrada = Console.ReadLine();
            var entradaValida = Int32.TryParse(entrada, out var valorLido);
            if (entradaValida)
                return valorLido;

            Console.WriteLine($"O valor informado [{entrada}] não é um número valido. Tente novamente");
            return PegarValor(mensagem);
        }

        static int Menu()
        {
            Console.WriteLine("Você deseja:");
            Console.WriteLine("  1 - Somar");
            Console.WriteLine("  2 - Subtrair");
            Console.WriteLine("  3 - Dividir");
            Console.WriteLine("  4 - Multiplicar");
            Console.WriteLine("  0 - Sair");
            var entrada = Console.ReadLine();
            var operacaoValida = Int32.TryParse(entrada, out var opcaoSelecionada);
            if (!operacaoValida)
            {
                Console.WriteLine("Informe um número válido");
                return Menu();
            }
            operacaoValida = opcaoSelecionada >= 0 && opcaoSelecionada <= 4;
            if (!operacaoValida)
            {
                Console.WriteLine("Informe um número entre 0-4");
                return Menu();
            }

            return opcaoSelecionada;
        }

        static void Calcular(int valorA, int valorB, int operacao)
        {
            var calculadora = new OperacaoMatematica(valorA, valorB);
            decimal resultado = -1;

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Operação selecionada: Somar");
                    resultado = calculadora.Somar();
                    break;
                case 2:
                    Console.WriteLine("Operação selecionada: Subtrair");
                    resultado = calculadora.Subtrair();
                    break;
                case 3:
                    Console.WriteLine("Operação selecionada: Dividir");
                    resultado = calculadora.Dividir();
                    break;
                case 4:
                    Console.WriteLine("Operação selecionada: Multiplicar");
                    resultado = calculadora.Multiplicar();
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("==================================");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int valorA = PegarValor("Informe o valor A");
            int valorB = PegarValor("Informe o valor B");
            var opcao = -1;
            while (opcao != 0)
            {
                opcao = Menu();
                if (opcao == 0)
                {
                    Console.WriteLine("Até logo!");
                    continue;
                }
                Calcular(valorA, valorB, opcao);
            }
        }
    }
}
