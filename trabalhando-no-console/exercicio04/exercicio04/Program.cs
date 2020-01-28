using System;
using System.Collections.Generic;

namespace exercicio04
{
    class Program
    {
        static void CarregarAlunos(List<Aluno> alunos)
        {
            while (true)
            {
                Console.Write("Nome do aluno [deixe em branco para encerrar]: ");
                var nomeAluno = Console.ReadLine();
                if (string.IsNullOrEmpty(nomeAluno))
                    break;
                var aluno = new Aluno(nomeAluno);
                AdicionarNotas(aluno);
                alunos.Add(aluno);
                Console.WriteLine("====================================================");
                Console.WriteLine("");
            }
        }
        static void AdicionarNotas(Aluno aluno)
        {
            while (true)
            {
                Console.Write("Nome da matéria [deixe em branco para encerrar]: ");
                var materia = Console.ReadLine();
                if (string.IsNullOrEmpty(materia))
                    break;
                Console.Write("Informe a nota do aluno: ");
                var notaCarregada = Console.ReadLine();
                var notaValida = Decimal.TryParse(notaCarregada, out var nota);
                if (!notaValida)
                {
                    Console.WriteLine("Nota informada inválida!");
                    break;
                }
                aluno.Notas.Add(new Nota(materia, nota));
            }
        }

        static void MostrarAlunosComMediaMaiorQueSete(List<Aluno> alunos)
        {
            Console.WriteLine("");
            Console.WriteLine("Mostrando alunos com nota maior que 7");
            foreach (var aluno in alunos)
            {
                var mediaCalculada = aluno.CalcularMedia();
                if (mediaCalculada > 7)
                    Console.WriteLine($"O aluno {aluno.Nome} possui média {mediaCalculada}");
            }
        }
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            CarregarAlunos(alunos);

            MostrarAlunosComMediaMaiorQueSete(alunos);
        }
    }
}
