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
        public void Vingt_ne_prend_pas_de_s_quand_suivi_de_mille()
        {
            Assert.AreEqual("quatre-vingt-mille", 80000.ToWords());
        }

        [TestMethod]
        public void Le_100_renvoie_cent()
        {
            Assert.AreEqual("cent", 100.ToWords());
        }

        [TestMethod]
        public void Les_centaines_avec_dizaines_ou_unites_sont_correctes()
        {
            Assert.AreEqual("cent-un", 101.ToWords());
            Assert.AreEqual("cent-onze", 111.ToWords());
            Assert.AreEqual("cent-vingt-trois", 123.ToWords());
            Assert.AreEqual("deux-cent-trente-quatre", 234.ToWords());
            Assert.AreEqual("cinq-cent-cinquante-et-un", 551.ToWords()); // -et-un
            Assert.AreEqual("huit-cent-quatre-vingts", 880.ToWords());   // s à 80
            Assert.AreEqual("huit-cent-quatre-vingt-un", 881.ToWords()); // ni s, ni et à 81
        }

        [TestMethod]
        public void Cent_est_au_pluriel_pour_les_multiples_de_100()
        {
            Assert.IsTrue(200.ToWords().Contains("cents"));
        }

        [TestMethod]
        public void Cent_est_au_singulier_si_pas_un_multiple_de_100()
        {
            Assert.IsFalse(201.ToWords().Contains("cents"));
        }

        [TestMethod]
        public void Cent_ne_prend_pas_de_s_quand_suivi_de_mille()
        {
            Assert.AreEqual("deux-cent-mille", 200000.ToWords());
        }

        [TestMethod]
        public void Le_1000_renvoie_mille()
        {
            Assert.AreEqual("mille", 1000.ToWords());
        }

        [TestMethod]
        public void Decoupe_par_blocs_de_3_chiffres()
        {
            Assert.AreEqual("mille-deux-cent-trente-quatre", 1234.ToWords());
            Assert.AreEqual("douze-mille-trois-cent-quarante-cinq", 12345.ToWords());
            Assert.AreEqual("cent-vingt-trois-mille-quatre-cent-cinquante-six", 123456.ToWords());
            Assert.AreEqual("cent-mille", 100000.ToWords());
        }

        [TestMethod]
        public void Mille_ne_prend_jamais_de_s()
        {
            Assert.IsFalse(2000.ToWords().Contains("milles"));
        }

        [TestMethod]
        public void Le_1_000_000_renvoie_un_million()
        {
            Assert.AreEqual("un million", 1000000.ToWords());
        }

        [TestMethod]
        public void Decoupe_en_3_blocs_de_3_chiffres()
        {
            Assert.AreEqual("un million deux-cent-trente-quatre-mille-cinq-cent-soixante-sept", 1234567.ToWords());
        }

        [TestMethod]
        public void Million_prend_un_s_au_pluriel()
        {
            Assert.IsTrue(2000000.ToWords().Contains("millions"));
        }

        [TestMethod]
        public void Les_milliards_ne_sont_pas_geres()
        {
            Assert.AreEqual(1000000000.ToString(), 1000000000.ToWords());
            Assert.AreNotEqual(999999999.ToString(), 999999999.ToWords());
        }

        [TestMethod]
        public void Un_nombre_negatif_commence_par_moins()
        {
            Assert.IsTrue((-123).ToWords().StartsWith("moins "));
        }

        [TestMethod]
        public void Les_milliards_negatifs_ne_sont_pas_geres()
        {
            Assert.AreEqual((-1000000000).ToString(), (-1000000000).ToWords());
            Assert.AreNotEqual((-999999999).ToString(), (-999999999).ToWords());
        }
    }
}

