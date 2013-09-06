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
            var oks = new[] { "", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };
            for (int i = 1; i < 20; i++)
            {
                Assert.AreEqual(oks[i], i.ToWords());
            }
        }

        [TestMethod]
        public void Les_dizaines_exactes_sont_correctes()
        {
            // En vrai, 80 s'écrit quatre-vingts et pas quatre-vingt, mais ce sera pour plus tard
            var oks = new[] { "", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix" };
            for (int i = 1; i < 10; i += 1)
            {
                Assert.AreEqual(oks[i], (i * 10).ToWords());
            }
        }

        [TestMethod]
        public void Les_dizaines_avec_unites_sont_correctes()
        {
            var oks = new[] { "", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix" };
            for (int i = 1; i < 10; i += 1)
            {
                Assert.AreEqual(oks[i] + "-sept", (i * 10 + 7).ToWords());
            }
        }
    }
}
