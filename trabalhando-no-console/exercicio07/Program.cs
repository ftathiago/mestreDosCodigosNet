using System;
using System.Collections.Generic;

namespace exercicio07
{
    class Program
    {
        static int LerNumerosInteiros()
        {
            Console.Write("Informe um número inteiro:");
            var inteiroEntrada = Console.ReadLine();
            var inteiroValido = Int32.TryParse(inteiroEntrada, out var inteiro);
            if (!inteiroValido)
            {
                Console.WriteLine("Entrada inválida! Tente novamente");
                return LerNumerosInteiros();
            }
            return inteiro;
        }
        static void Main(string[] args)
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
    }
}
