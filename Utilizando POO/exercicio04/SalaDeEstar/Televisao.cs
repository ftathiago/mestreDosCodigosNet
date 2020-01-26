namespace SalaDeEstar
{
    public class Televisao
    {
        private string[] _canais;
        private int _canalSintonizado = 0;

        public string SintonizadaEm
        {
            get => _canais[_canalSintonizado];
        }
        public Televisao(string[] listaDeCanais)
        {
            _canais = new string[listaDeCanais.Length];
        }
        public void CanalProximo()
        {
            _canalSintonizado++;
            if (_canalSintonizado > _canais.Length)
                _canalSintonizado = 0;
        }

        public void CanalAnterior()
        {
            _canalSintonizado--;
            if (_canalSintonizado < 0)
                _canalSintonizado = _canais.Length;
        }
    }
}