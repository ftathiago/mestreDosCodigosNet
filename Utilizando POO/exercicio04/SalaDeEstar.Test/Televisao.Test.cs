using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaDeEstar;

namespace SalaDeEstar.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly string[] _canais = { "Globo", "HBO", "Universal", "Telecine" };
        [TestMethod]
        public void ShouldCreateTelevisao()
        {
            Televisao televisao = new Televisao(_canais);
            Assert.IsNotNull(televisao);
        }

        [TestMethod]
        public void ShouldChangeToNextChannelIncreasedByOne()
        {
            Televisao televisao = PegarTelevisao();
            var canalEsperado = _canais[1];

            televisao.CanalProximo();

            Assert.AreEqual(canalEsperado, televisao.SintonizadaEm);
        }

        [TestMethod]
        public void ShouldChangeToPreviousChannel()
        {
            Televisao televisao = PegarTelevisao();
            var canalAtual = televisao.SintonizadaEm;
            var canalEsperado = _canais[1];

            televisao.CanalAnterior();

            Assert.AreEqual(canalEsperado, televisao.SintonizadaEm);
        }

        private Televisao PegarTelevisao()
        {
            return new Televisao(_canais);
        }
    }
}
