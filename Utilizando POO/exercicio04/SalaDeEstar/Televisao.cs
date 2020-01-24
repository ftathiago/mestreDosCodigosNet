namespace SalaDeEstar
{
    public class Televisao
    {
        public int SintonizadaEm { get; private set; }
        public Televisao(int canalInicial)
        {
            SintonizadaEm = canalInicial;
        }
        public void CanalProximo()
        {
            SintonizadaEm++;
        }

        public void CanalAnterior()
        {
            SintonizadaEm--;
        }
    }
}