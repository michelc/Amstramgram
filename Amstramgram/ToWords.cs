namespace Amstramgram
{
    public static class ToWordsExtension
    {
        public static string ToWords(this int number)
        {
            if (number == 0) return "zéro";

            return number.ToString();
        }
    }
}

