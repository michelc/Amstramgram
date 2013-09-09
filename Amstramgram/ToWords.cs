namespace Amstramgram
{
    public static class ToWordsExtension
    {
        public static string ToWords(this int number)
        {
            // Ne gère pas les millions
            if (number >= 1000000) return number.ToString();

            // Le zéro est un cas un peu spécial
            if (number == 0) return "zéro";

            var text = "";

            int millier = number / 1000;
            if (millier > 0)
            {
                text += millier == 1 ? "mille" : Textify(millier) + "-mille";
                number = number % 1000;
                if (number > 0) text += "-";
            }

            text += Textify(number);

            return text;
        }

        private static string Textify(int number)
        {
            // Les nombres basiques qui serviront à former des combinaisons
            var basics = new[] { "", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };

            // Les mots qui serviront à former les dizaines
            var tens = new[] { "", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante", "quatre-vingt", "quatre-vingt" };

            var text = "";

            // Gère les centaines
            if (number > 99)
            {
                // Ecrit le chiffre des centaines
                int result = number / 100;
                int remainder = number % 100;

                if (result == 1)
                {
                    // cent... et pas un-cent...
                    text = "cent";
                }
                else
                {
                    // deux-cent..., trois-cent...
                    text = basics[result] + "-cent";
                    if (remainder == 0) text += "s";
                }

                // Reste à écrire les dizaines et les unités
                number = remainder;
            }

            // Gère les petits nombres (codés en dur)
            if (number < 20)
            {
                if (number > 0)
                {
                    if (text != "") text += "-";
                    text += basics[number];
                }
            }

            // Gère les dizaines et les unités
            if (number > 19)
            {
                int result = number / 10;
                int remainder = number % 10;

                // - la dizaine
                if (text != "") text += "-";
                text += tens[result];

                // - cas où l'unité vaut 1
                if (remainder == 1)
                {
                    // la dizaine est séparée de l'unité par "et"
                    // pour 21, 31, 41, 51, 61, 71 mais pas 81 et 91
                    if (result < 8) text += "-et";
                }

                // - pluriel de vingt
                if (result == 8)
                {
                    // quatre-vingts prend un "s" quand pas suivi d'un autre nombre
                    if (remainder == 0) text += "s";
                }

                // l'unité
                if (result == 7)
                {
                    remainder += 10;
                }
                else if (result == 9)
                {
                    remainder += 10;
                }
                if (remainder > 0)
                {
                    if (text != "") text += "-";
                    text += basics[remainder];
                }
            }

            // Renvoie le texte pour 0 à 999
            return text;
        }
    }
}
