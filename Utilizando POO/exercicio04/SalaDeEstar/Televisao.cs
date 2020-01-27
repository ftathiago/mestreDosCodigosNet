using System.Text;

namespace SalaDeEstar
{
    public class Televisao: ITelevisao
    {
        private string[] _canais;
        private int _canalSintonizado = 0;
        private const int VOLUME_MINIMO = 0;
        private const int VOLUME_MAXIMO = 100;

        public int VolumeAtual { get; private set; }
        public string SintonizadaEm
        {
            get => _canais[_canalSintonizado];
        }
        public Televisao(string[] listaDeCanais)
        {
            VolumeAtual = 50;
            _canais = new string[listaDeCanais.Length];
            for (int i = 0; i < listaDeCanais.Length; i++)
                _canais[i] = listaDeCanais[i];
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
                _canalSintonizado = _canais.Length-1;
        }

        public void VolumeAumentar()
        {
            VolumeAtual++;
            if (VolumeAtual > VOLUME_MAXIMO)
                VolumeAtual = VOLUME_MAXIMO;
        }

        public void VolumeDiminuir()
        {
            VolumeAtual--;
            if (VolumeAtual < VOLUME_MINIMO)
                VolumeAtual = VOLUME_MINIMO;
        }

        public bool MudarParaCanal(int canal)
        {
            if ((canal <= 0) || (canal > _canais.Length))
                return false;
            _canalSintonizado = canal -1;
            return true;
        }

        public string Display()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Canal: {SintonizadaEm}");
            stringBuilder.AppendLine($"Volume: {VolumeAtual}");
            return stringBuilder.ToString();
        }
    }
}