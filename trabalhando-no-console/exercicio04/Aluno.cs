using System.Collections.Generic;

namespace exercicio04
{
    public class Nota
    {
        public string Materia { get; private set; }
        public decimal Valor { get; private set; }

        public Nota(string materia, decimal valor)
        {
            Materia = materia;
            Valor = valor;
        }
    }
    public class Aluno
    {
        public string Nome { get; set; }
        public List<Nota> Notas { get; private set; }
        public Aluno(string nome)
        {
            Nome = nome;
            Notas = new List<Nota>();
        }

        public decimal CalcularMedia()
        {
            var soma = 0M;
            foreach (var nota in Notas)
                soma = soma + nota.Valor;
            return soma / Notas.Count;
        }
    }
}