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
            Televisao televisao = new Televisao();
            Assert.IsNotNull(televisao);
        }
    }
}
