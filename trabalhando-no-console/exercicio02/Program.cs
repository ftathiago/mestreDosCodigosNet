using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario maiorSalario = new Funcionario();
            Funcionario menorSalario = new Funcionario();

            while (true)
            {
                Console.WriteLine("Digite o nome do funcionário [0 = sair]");
                var nome = Console.ReadLine();
                if (nome == "0")
                    break;

                Console.WriteLine("Digite o salário");
                var salarioEntrada = Console.ReadLine();

                bool salarioValido = Decimal.TryParse(salarioEntrada, out var salario);
                if (!salarioValido)
                {
                    Console.WriteLine("Valor de salário informado inválido!");
                    break;
                }

                var funcionario = new Funcionario(nome, salario);

                var ehMenorSalario = funcionario.Salario < menorSalario.Salario;
                if (ehMenorSalario)
                    menorSalario = funcionario;

                var ehMaiorSalario = funcionario.Salario > maiorSalario.Salario;
                if (ehMaiorSalario)
                    maiorSalario = funcionario;
            }

            Console.WriteLine($"Funcionario com menor salário: {menorSalario.Nome} - R$ {menorSalario.Salario}");
            Console.WriteLine($"Funcionario com mario salário: {maiorSalario.Nome} - R$ {maiorSalario.Salario}");
        }
    }
}
