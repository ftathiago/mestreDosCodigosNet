using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaDeEstar;

namespace SalaDeEstar.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldCreateTelevisao()
        {
            var canalInicial = 0;
            Televisao televisao = new Televisao(canalInicial);
            Assert.IsNotNull(televisao);
        }

        [TestMethod]
        public void ShouldChangeToNextChannelIncreasedByOne()
        {
            Televisao televisao = PegarTelevisao();
            var canalAtual = televisao.SintonizadaEm;
            var canalEsperado = canalAtual + 1;

            televisao.CanalProximo();

            Assert.AreEqual(canalEsperado, televisao.SintonizadaEm);
        }

        [TestMethod]
        public void ShouldChangeToPreviousChannel()
        {
            Televisao televisao = PegarTelevisao();
            var canalAtual = televisao.SintonizadaEm;
            var canalEsperado = canalAtual - 1;

            televisao.CanalAnterior();

            Assert.AreEqual(canalEsperado, televisao.SintonizadaEm);
        }

        private Televisao PegarTelevisao()
        {
            var canalInicial = 0;
            return new Televisao(canalInicial);
        }
    }
}
