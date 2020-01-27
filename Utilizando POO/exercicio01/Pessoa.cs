using System;
using System.Collections.Generic;
namespace exercicio01
{
    public class Pessoa : HomoSapiens, IComparable<Pessoa>, ICloneable
    {
        /* Demonstrando encapsulamento */
        private string _nome;
        private DateTime _dataNascimento;
        private double _altura;

        public Pessoa(string nome, DateTime dataNascimento, double altura)
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
            _altura = altura;
        }

        public string GetNome() =>
            _nome;
        public void SetNome(string nome) =>
            _nome = nome;

        public DateTime GetDataNascimento() =>
            _dataNascimento;
        public void SetDataNascimento(DateTime dataNascimento) =>
            _dataNascimento = dataNascimento;

        public double GetAltura() =>
            _altura;

        public void SetAltura(double altura) =>
            _altura = altura;

        public int Idade()
        {
            var hoje = DateTime.Now;
            int diferencaAno = hoje.Year - _dataNascimento.Year;
            bool jaFezAniversario = (hoje.Month >= _dataNascimento.Month) && (hoje.Day >= _dataNascimento.Day);
            if (jaFezAniversario)
                return diferencaAno;
            return diferencaAno--;
        }

        public override string Comunicar()
        {
            return "Pessoas falam";
        }

        public override string ToString() =>
            String.Format($"Nome: {_nome}; Data de nascimento: {_dataNascimento}; Altura: {_altura}");

        public int CompareTo(Pessoa pessoa)
        {
            /* 
                -1 this precede pessoa
                0 this e pessoa sao iguais
                1 this segue adiante de pessoa

                Neste exemplo, a ordenação é para que os mais velhos fiquem adiante na fila
            */
            if (pessoa == null) return 1;

            if (pessoa.Idade() < this.Idade())
                return -1;
            if (pessoa.Idade() > this.Idade())
                return 1;
            return pessoa.GetNome().CompareTo(this.GetNome());
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Pessoa Clone()
        {
            return new Pessoa(this.GetNome(), this.GetDataNascimento(), this.GetAltura());
        }
    }
}