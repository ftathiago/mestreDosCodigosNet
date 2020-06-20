using System.Collections;

namespace exercicio01
{
    public class Galera : IEnumerable
    {
        private Pessoa[] _pessoas;
        public Galera(Pessoa[] pessoas)
        {
            _pessoas = new Pessoa[pessoas.Length];
            for (int i = 0; i < _pessoas.Length; i++)
                _pessoas[i] = pessoas[i];
        }

        public IEnumerator GetEnumerator()
        {
            return new PessoaEnum(_pessoas);
        }
    }

    public class PessoaEnum : IEnumerator
    {
        private Pessoa[] _pessoas;
        private int _posicao = -1;

        public PessoaEnum(Pessoa[] pessoas)
        {
            _pessoas = pessoas;
        }
        public Pessoa Current =>
            _pessoas[_posicao];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _posicao++;
            return (_posicao < _pessoas.Length);
        }

        public void Reset()
        {
            _posicao = -1;
        }
    }
}