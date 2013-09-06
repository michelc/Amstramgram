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

        [TestMethod]
        public void Les_nombres_de_1_a_19_sont_corrects()
        {
            var basics = new[] { "", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };
            for (int i = 1; i < 20; i++)
            {
                Assert.AreEqual(basics[i], i.ToWords());
            }
        }
    }
}
