namespace Amstramgram
{
    public static class ToWordsExtension
    {
        public static string ToWords(this int number)
        {
            // Le zéro est un cas un peu spécial
            if (number == 0) return "zéro";

            // Les nombres basiques qui serviront à former des combinaisons
            var basics = new[] { "", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf" };

            if (number < 20) return basics[number];

            return number.ToString();
        }
    }
}

