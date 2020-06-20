using System;

/* 3. Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while.*/

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

