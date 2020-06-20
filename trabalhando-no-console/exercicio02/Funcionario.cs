namespace exercicio02
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public decimal Salario { get; private set; }
        public Funcionario(string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public Funcionario()
        {
            Nome = string.Empty;
            Salario = 0;
        }
    }
}