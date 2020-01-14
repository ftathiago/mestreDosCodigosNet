using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            while (i <= 100)
            {
                var ehDivisivel = (i % 3) == 0;
                if (ehDivisivel)
                    Console.WriteLine($"O número {i} é divisível por 3");
                i++;
            }
        }
    }
}

