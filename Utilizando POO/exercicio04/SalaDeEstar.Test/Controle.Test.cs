using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;
using System.Text;

namespace SalaDeEstar.Test
{
    [TestClass]
    public class ControleTest
    {
        private const int INITIAL_VOLUME = 50;
        private Mock<ITelevisao> _televisao;

        [TestInitialize]
        public void Initialize()
        {
            _televisao = new Mock<ITelevisao>();
        }

        [TestMethod]
        public void ShouldCreateControle()
        {
            ITelevisao televisao = _televisao.Object;
            Controle controle = new Controle(televisao);

            Assert.IsNotNull(controle);
        }

        [TestMethod]
        public void ShouldIncreaseVolume()
        {
            _televisao
                .Setup(x => x.VolumeAumentar())
                .Verifiable();
            Controle controle = GetControle(_televisao);

            controle.VolumeAumentar();

            _televisao.Verify(x => x.VolumeAumentar(), Times.Once);
        }

        [TestMethod]
        public void ShouldDecreaseVolume()
        {
            _televisao
                .Setup(x => x.VolumeDiminuir())
                .Verifiable();
            Controle controle = GetControle(_televisao);

            controle.VolumeDiminuir();

            _televisao.Verify(x => x.VolumeDiminuir(), Times.Once);
        }

        [TestMethod]
        public void ShouldGoToNextChannel()
        {
            _televisao
                .Setup(x => x.CanalProximo())
                .Verifiable();
            Controle controle = GetControle(_televisao);

            controle.CanalProximo();

            _televisao.Verify(x => x.CanalProximo(), Times.Once);
        }

        [TestMethod]
        public void ShouldGoToPreviousChannel()
        {
            _televisao
                .Setup(x => x.CanalAnterior())
                .Verifiable();
            Controle controle = GetControle(_televisao);

            controle.CanalAnterior();

            _televisao.Verify(x => x.CanalAnterior(), Times.Once);
        }

        [TestMethod]
        public void ShouldChangeToSpecifiedChannel()
        {
            _televisao
                .Setup(x => x.MudarParaCanal(It.Is<int>(p => p == 10)))
                .Verifiable();
            Controle controle = GetControle(_televisao);

            controle.MudarCanalPara(10);

            _televisao.Verify();
        }

        [TestMethod]
        public void ShouldDisplayInfo()
        {
            StringBuilder televisaoDisplay = new StringBuilder();
            televisaoDisplay.AppendLine($"Canal: Globo");
            televisaoDisplay.Append($"Volume: {INITIAL_VOLUME}");

            StringBuilder expectedDisplay = new StringBuilder();
            expectedDisplay.AppendLine();
            expectedDisplay.AppendLine("+-----------------------------+");
            expectedDisplay.AppendLine("Dados da TV:");
            expectedDisplay.AppendLine($"Canal: Globo");
            expectedDisplay.AppendLine($"Volume: {INITIAL_VOLUME}");
            expectedDisplay.AppendLine("+-----------------------------+");
            _televisao
                .Setup(x => x.Display())
                .Returns(televisaoDisplay.ToString)
                .Verifiable();

            Controle controle = GetControle(_televisao);

            var displayInfo = controle.DisplayInfo();

            Assert.AreEqual(expectedDisplay.ToString(), displayInfo);
            _televisao.Verify(x => x.Display(), Times.Once);
        }


        private Controle GetControle(Mock<ITelevisao> televisao)
        {
            return new Controle(televisao.Object);
        }
    }
}
