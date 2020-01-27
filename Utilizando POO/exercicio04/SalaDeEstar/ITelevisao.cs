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
        bool MudarParaCanal(int canal);
        string Display();
    }
}
