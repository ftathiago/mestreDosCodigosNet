using System;

namespace exercicio01
{
    /* Demonstrando POO, abstração */
    public class Funcionario : Pessoa
    {
        /* Demonstrando encapsulamento */
        public string RegistroFuncional { get; private set; }
        public Funcionario(string registroFuncional, string nome, DateTime dataNascimento, double altura) :
            base(nome, dataNascimento, altura)
        {
            RegistroFuncional = registroFuncional;
        }

        /* Demonstrando Polimorfismo */
        public override string Comunicar()
        {
            return "Funcionarios mandam memorandos e e-mails";
        }

        /* Demonstrando Polimorfismo */
        public string ToString() =>
            String.Format($"Registro Funcional: {RegistroFuncional}; Nome: {GetNome}; Data de nascimento: {GetDataNascimento}; Altura: {GetAltura}");
    }
}