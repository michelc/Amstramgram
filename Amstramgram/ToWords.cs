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

            // Gère les dizaines et les unités
            var tens = new[] { "", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante", "quatre-vingt", "quatre-vingt" };

            int result = number / 10;
            int remainder = number % 10;

            var text = tens[result];
            if (result == 7)
            {
                remainder += 10;
            }
            if (result == 9)
            {
                remainder += 10;
            }
            if (remainder > 0)
            {
                text += "-";
                text += basics[remainder];
            }
            return text;
        }
    }
}

