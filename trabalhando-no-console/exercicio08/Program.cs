using System;
using System.Collections.Generic;
using System.Linq;

/* 8. Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente. */

namespace exercicio08
{

    class Program
    {
        public static void Main(string[] args)
        {
            var tamanhoLeitura = LerInteiro("Informe a quantidade de itens para leitura: ");
            List<int> inteiros = new List<int>();
            for (int i = 0; i < tamanhoLeitura; i++)
            {
                var inteiroLido = LerInteiro($"Informe o inteiro {i + 1}: ");
                inteiros.Add(inteiroLido);
            }

            Console.WriteLine("Entradas em ordem descendente:");
            var inteirosDesc = inteiros.OrderByDescending(x => x).ToList();
            foreach (var inteiro in inteirosDesc)
            {
                Console.Write(inteiro + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Entradas em ordem ascendente:");
            var inteirosAsc = inteiros.OrderBy(x => x).ToList();
            foreach (var inteiro in inteirosAsc)
            {
                Console.Write(inteiro + ", ");
            }
        }

        private static int LerInteiro(String mensagem)
        {
            Console.Write(mensagem);
            var entrada = Console.ReadLine();
            var entradaValida = Int32.TryParse(entrada, out var inteiro);
            if (!entradaValida)
            {
                Console.WriteLine("Entrada inválida!");
                return LerInteiro(mensagem);
            }
            return inteiro;
        }
    }
}
