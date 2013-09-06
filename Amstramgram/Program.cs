using System;

namespace Amstramgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ecrire(0, "zéro");
            Ecrire(1, "un");

            Console.ResetColor();
            Console.WriteLine("\nFini");
            Console.ReadLine();
        }

        static void Ecrire(int number, string reponse)
        {
            var resultat = number.ToWords();
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
