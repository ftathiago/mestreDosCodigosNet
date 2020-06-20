using System;
using System.Collections.Generic;

/* 7. Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.  */

namespace exercicio07
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> inteiros = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                var inteiroLido = LerNumerosInteiros();
                inteiros.Add(inteiroLido);
            }
            var soma = 0;
            foreach (var inteiro in inteiros)
            {
                var ehPar = (inteiro % 2) == 0;
                if (ehPar)
                    soma += inteiro;
            }

            Console.WriteLine($"Soma dos números pares: {soma}");
        }

        private static int LerNumerosInteiros()
        {
            Console.Write("Informe um número inteiro:");
            var inteiroEntrada = Console.ReadLine();
            var inteiroValido = int.TryParse(inteiroEntrada, out var inteiro);
            if (!inteiroValido)
            {
                Console.WriteLine("Entrada inválida! Tente novamente");
                return LerNumerosInteiros();
            }
            return inteiro;
        }

    }
}
