using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalaDeEstar;
using System.Text;

namespace SalaDeEstar.Test
{
    [TestClass]
    public class TelevisaoTest
    {
        private readonly string[] _channels = { "Globo", "HBO", "Universal", "Telecine" };
        private const int VOLUME_START = 50;
        private const int VOLUME_MAX = 100;
        private const int VOLUME_MIN = 0;

        [TestMethod]
        public void ShouldCreateTelevisao()
        {
            Televisao televisao = new Televisao(_channels);
            Assert.IsNotNull(televisao);
        }

        [TestMethod]
        public void ShouldChangeToNextChannelIncreasedByOne()
        {
            Televisao televisao = GetTelevisao();
            var expectedChannel = _channels[1];

            televisao.CanalProximo();

            Assert.AreEqual(expectedChannel, televisao.SintonizadaEm);
        }

        [TestMethod]
        public void ShouldChangeToPreviousChannel()
        {
            Televisao televisao = GetTelevisao();
            int lastChannel = _channels.Length - 1;
            var expectedChannel = _channels[lastChannel];

            televisao.CanalAnterior();

            Assert.AreEqual(expectedChannel, televisao.SintonizadaEm);
        }

        [TestMethod]
        public void ShouldChangeToSpecifiedChannel()
        {
            Televisao televisao = GetTelevisao();
            var firstChannel = 1;

            bool channelChanged = televisao.MudarParaCanal(firstChannel);

            Assert.IsTrue(channelChanged);
        }

        [TestMethod]
        public void ShouldNotChangeToInvalidChannel()
        {
            Televisao televisao = GetTelevisao();
            var channelOutOfBounds = _channels.Length + 1;

            bool channelChanged = televisao.MudarParaCanal(channelOutOfBounds);

            Assert.IsFalse(channelChanged);
        }

        [TestMethod]
        public void ShouldVolumeStartAtFifty()
        {
            Televisao televisao = GetTelevisao();

            int starVolume = televisao.VolumeAtual;

            Assert.AreEqual(VOLUME_START, starVolume);
        }

        [TestMethod]
        public void ShouldIncreaseVolumeByOne()
        {
            Televisao televisao = GetTelevisao();
            var expectedVolume = VOLUME_START + 1;

            televisao.VolumeAumentar();

            Assert.AreEqual(expectedVolume, televisao.VolumeAtual);
        }

        [TestMethod]
        public void ShouldDecreaseVolumeByOne()
        {
            Televisao televisao = GetTelevisao();
            var expectedVolume = VOLUME_START - 1;

            televisao.VolumeDiminuir();

            Assert.AreEqual(expectedVolume, televisao.VolumeAtual);
        }

        [TestMethod]
        public void ShouldNotTrespassMaxVolume()
        {
            Televisao televisao = GetTelevisao();
            var triesToTrespassMaxVol = VOLUME_MAX - VOLUME_START + 1;

            for (int i = 0; i < triesToTrespassMaxVol; i++)
                televisao.VolumeAumentar();

            Assert.AreEqual(VOLUME_MAX, televisao.VolumeAtual);
        }

        [TestMethod]
        public void ShouldNotTrespassMinVolume()
        {
            Televisao televisao = GetTelevisao();
            var triesToTrespassMinVol = VOLUME_START + 1;

            for (int i = 0; i < triesToTrespassMinVol; i++)
                televisao.VolumeDiminuir();

            Assert.AreEqual(VOLUME_MIN, televisao.VolumeAtual);
        }

        [TestMethod]
        public void ShouldDisplayInfo()
        {
            Televisao televisao = GetTelevisao();
            StringBuilder expectedDisplay = new StringBuilder();
            expectedDisplay.AppendLine($"Canal: {_channels[0]}");
            expectedDisplay.AppendLine($"Volume: {VOLUME_START}");

            var displayInfo = televisao.Display();

            Assert.AreEqual(expectedDisplay.ToString(), displayInfo);
        }

        private Televisao GetTelevisao()
        {
            return new Televisao(_channels);
        }
    }
}
