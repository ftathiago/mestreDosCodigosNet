using System;
using System.Collections.Generic;
using System.Linq;

/*
2. Crie uma aplicação que receba nome e salario de N funcionários. Utilize a repetição for e while.
    - Imprima o maior salario
    - Imprima o menor salario. 
*/
namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionarios = new List<Funcionario>();

            Funcionario maiorSalario;
            Funcionario menorSalario;

            while (true)
            {
                Console.WriteLine("Digite o nome do funcionário [0 = sair]");
                var nome = Console.ReadLine();
                if (nome == "0")
                    break;

                Console.WriteLine("Digite o salário");
                var salarioEntrada = Console.ReadLine();

                var salarioValido = decimal.TryParse(salarioEntrada, out var salario);
                if (!salarioValido)
                {
                    Console.WriteLine("Valor de salário informado inválido!");
                    continue;
                }

                var funcionario = new Funcionario(nome, salario);
                funcionarios.Add(funcionario);
            }

            maiorSalario = funcionarios.FirstOrDefault();
            menorSalario = maiorSalario;

            for (int i = 1; i < funcionarios.Count(); i++)
            {
                var funcionario = funcionarios[i];

                var ehMenorSalario = menorSalario.Salario > funcionario.Salario;
                var ehMaiorSalario = maiorSalario.Salario < funcionario.Salario;

                if (ehMenorSalario)
                    menorSalario = funcionario;
                if (ehMaiorSalario)
                    maiorSalario = funcionario;
            }

            Console.WriteLine($"Funcionario com menor salário: {menorSalario.Nome} - R$ {menorSalario.Salario}");
            Console.WriteLine($"Funcionario com mario salário: {maiorSalario.Nome} - R$ {maiorSalario.Salario}");
        }
    }
}
