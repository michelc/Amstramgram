using System;

namespace Amstramgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ecrire("0 s'écrit zéro");
            Ecrire(0, "zéro");

            Ecrire("1 à 19 sont codés en dur");
            Ecrire(1, "un");
            Ecrire(2, "deux");
            Ecrire(3, "trois");
            Ecrire(4, "quatre");
            Ecrire(5, "cinq");
            Ecrire(6, "six");
            Ecrire(7, "sept");
            Ecrire(8, "huit");
            Ecrire(9, "neuf");
            Ecrire(10, "dix");
            Ecrire(11, "onze");
            Ecrire(12, "douze");
            Ecrire(13, "treize");
            Ecrire(14, "quatorze");
            Ecrire(15, "quinze");
            Ecrire(16, "seize");
            Ecrire(17, "dix-sept");
            Ecrire(18, "dix-huit");
            Ecrire(19, "dix-neuf");

            Ecrire("10, 20 ... 90 sont codés en dur");
            Ecrire(10, "dix");
            Ecrire(20, "vingt");
            Ecrire(30, "trente");
            Ecrire(40, "quarante");
            Ecrire(50, "cinquante");
            Ecrire(60, "soixante");
            Ecrire(70, "soixante-dix");
            Ecrire(80, "quatre-vingts");
            Ecrire(90, "quatre-vingt-dix");

            Ecrire("Combinaisons dizaines et unités");
            Ecrire(17, "dix-sept");
            Ecrire(27, "vingt-sept");
            Ecrire(37, "trente-sept");
            Ecrire(47, "quarante-sept");
            Ecrire(57, "cinquante-sept");
            Ecrire(67, "soixante-sept");
            Ecrire(77, "soixante-dix-sept");
            Ecrire(87, "quatre-vingt-sept");
            Ecrire(97, "quatre-vingt-dix-sept");

            Ecrire("Combinaisons dizaines et 1");
            Ecrire(21, "vingt-et-un");
            Ecrire(31, "trente-et-un");
            Ecrire(41, "quarante-et-un");
            Ecrire(51, "cinquante-et-un");
            Ecrire(61, "soixante-et-un");
            Ecrire(71, "soixante-et-onze");
            Ecrire(81, "quatre-vingt-un");
            Ecrire(91, "quatre-vingt-onze");

            Ecrire("Vingt au singulier devant mille");
            Ecrire(80000, "quatre-vingt-mille");

            Ecrire("100 s'écrit cent");
            Ecrire(100, "cent");

            Ecrire("Combinaisons centaines, dizaines et unités");
            Ecrire(101, "cent-un");
            Ecrire(111, "cent-onze");
            Ecrire(123, "cent-vingt-trois");
            Ecrire(234, "deux-cent-trente-quatre");
            Ecrire(551, "cinq-cent-cinquante-et-un");
            Ecrire(880, "huit-cent-quatre-vingts");
            Ecrire(881, "huit-cent-quatre-vingt-un");

            Ecrire("Fin");
            Console.ReadLine();
        }

        static void Ecrire(string texte)
        {
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(texte);
            Console.WriteLine(new String('-', texte.Length));
        }

        static void Ecrire(int number, string reponse)
        {
            var resultat = number.ToString();
            try
            {
                resultat = number.ToWords();
            }
            catch { }
            if (reponse == resultat)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Format("OK : {0}.ToWords() => '{1}'", number, resultat));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("KO : {0}.ToWords() => '{1}' et pas '{2}'", number, resultat, reponse));
            }
        }
    }
}
