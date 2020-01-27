using System.Text;

namespace SalaDeEstar
{
    public class Controle
    {
        public readonly ITelevisao _televisao;
        public Controle(ITelevisao televisao)
        {
            _televisao = televisao;
        }

        public void VolumeAumentar()
        {
            _televisao.VolumeAumentar();
        }

        public void VolumeDiminuir()
        {
            _televisao.VolumeDiminuir();
        }

        public void CanalProximo()
        {
            _televisao.CanalProximo();
        }

        public void CanalAnterior()
        {
            _televisao.CanalAnterior();
        }

        public void MudarCanalPara(int numeroCanal)
        {
            _televisao.MudarParaCanal(numeroCanal);
        }

        public string DisplayInfo()
        {
            StringBuilder displayInfo = new StringBuilder();
            displayInfo.AppendLine();
            displayInfo.AppendLine("+-----------------------------+");
            displayInfo.AppendLine("Dados da TV:");
            displayInfo.AppendLine(_televisao.Display());
            displayInfo.AppendLine("+-----------------------------+");
            return displayInfo.ToString();
        }
    }
}
