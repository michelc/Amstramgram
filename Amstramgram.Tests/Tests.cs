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
            var oks = new[] { "", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingts", "quatre-vingt-dix" };
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

        [TestMethod]
        public void Les_dizaines_avec_une_unite_prennent_et_devant_l_unite()
        {
            for (int i = 21; i < 81; i += 10)
            {
                Assert.IsTrue(i.ToWords().Contains("-et-"));
            }
        }

        [TestMethod]
        public void Les_nombres_81_et_91_ne_contiennent_pas_de_et_devant_l_unite()
        {
            Assert.IsFalse(81.ToWords().Contains("-et-"));
            Assert.IsFalse(91.ToWords().Contains("-et-"));
        }

        [TestMethod]
        public void Pas_de_s_a_80_quand_suivi_de_mille()
        {
            Assert.AreEqual("quatre-vingt-mille", 80000.ToWords());
        }
    }
}
