using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio09
{
    class Program
    {
        static int LerInteiro(String mensagem)
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
        static void Main(string[] args)
        {
            var tamanhoLeitura = LerInteiro("Informe a quantidade de itens para leitura: ");
            List<int> inteiros = new List<int>();
            for (int i = 0; i < tamanhoLeitura; i++)
            {
                var inteiroLido = LerInteiro($"Informe o inteiro {i + 1}: ");
                inteiros.Add(inteiroLido);
            }


            Console.WriteLine("Imprimindo todos os números da lista:");
            inteiros.ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            Console.WriteLine("Imprimir todos os números da lista em ordem crescente:");
            inteiros.OrderBy(x => x)
                .ToList()
                .ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            Console.WriteLine("Imprimir todos os números da lista em ordem descrescente:");
            inteiros.OrderByDescending(x => x)
                .ToList()
                .ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            Console.Write("Imprima apenas o primeiro número da lista: ");
            Console.WriteLine(inteiros.First());

            Console.Write("Imprima apenas o último número da lista: ");
            Console.WriteLine(inteiros.Last());

            Console.WriteLine("Insira um número no início da lista:");
            inteiros.Insert(0, 99);
            inteiros.ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            Console.WriteLine("Insira um número no final da lista:");
            inteiros.Insert(inteiros.Count, 99);
            inteiros.ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            Console.WriteLine("Remova o primeiro número");
            inteiros.RemoveAt(0);
            inteiros.ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            Console.WriteLine("Remova o último número");
            inteiros.RemoveAt(inteiros.Count - 1);
            inteiros.ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            Console.WriteLine("Retorne apenas os números pares");
            inteiros
                .Where(x => (x % 2) == 0)
                .ToList()
                .ForEach(x => Console.Write($"{x}, "));
            Console.WriteLine();

            var numeroInformado = LerInteiro("Informe um número e veremos se ele está na lista: ");
            int numeroEncontrado = inteiros.Where(x => x == numeroInformado).FirstOrDefault();
            String mensagem = (numeroEncontrado == 0) ?
                $"O número {numeroInformado} não foi encontrado na lista." :
                "O número foi encontrado na lista!";
            Console.WriteLine(mensagem);

            Console.WriteLine("Transforme todos os numeros da lista em um array");
            var arranjo = inteiros.ToArray();
            foreach (var item in arranjo)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Até logo!");
        }
    }
}
