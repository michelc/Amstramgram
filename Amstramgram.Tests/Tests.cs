using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Amstramgram.Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Le_0_renvoie_zero()
        {
            Assert.AreEqual("zéro", 0.ToWords());
        }
    }
}
