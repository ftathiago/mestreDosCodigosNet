using System;

namespace exercicio05
{
    class Program
    {
        static int CarregarElemento(string nomeElemento)
        {
            Console.Write($"Valor da variável {nomeElemento}: ");
            var elemento = Console.ReadLine();
            return Int32.Parse(elemento);
        }
        static void Main(string[] args)
        {
            int a = CarregarElemento("A");
            int b = CarregarElemento("B");
            int c = CarregarElemento("C");

            var delta = Math.Pow(b, 2) - 4 * a * c;
            var resultado1 = ((b * -1) + Math.Sqrt(delta)) / (2 * a);
            var resultado2 = ((b * -1) - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine($"R1: {resultado1}");
            Console.WriteLine($"R2: {resultado2}");
        }
    }
}
