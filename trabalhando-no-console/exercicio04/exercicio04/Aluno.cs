using System.Collections.Generic;

namespace exercicio04
{
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