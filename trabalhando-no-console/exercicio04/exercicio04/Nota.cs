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
}