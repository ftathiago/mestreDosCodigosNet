using System;
namespace exercicio04
{
    public class Nota
    {
        public string Materia { get; private set; }
        public decimal Conceito { get; private set; }

        public Nota(string materia, decimal conceito)
        {
            if (conceito < 0 || conceito > 10)
                throw new ArgumentOutOfRangeException("O conceito deve ser entre 1 e 10");
            Materia = materia;
            Conceito = conceito;
        }
    }
}