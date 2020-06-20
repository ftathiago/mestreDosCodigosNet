using System.Collections;
using System.Collections.Generic;

namespace SalaDeEstar
{
    public interface ITelevisao
    {
        int VolumeAtual { get; }
        string SintonizadaEm {get ;}
        void CanalProximo();
        void CanalAnterior();
        void VolumeAumentar();
        void VolumeDiminuir();
        IEnumerable<string> MostrarCanaisDisponiveis();
        bool MudarParaCanal(int canal);
        string Display();
    }
}
