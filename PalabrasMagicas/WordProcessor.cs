namespace PalabrasMagicas
{
    public static class WordProcessor
    {
        public static string ReverseWord(string word)
        {
            char[] characters = word.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }

        public static bool IsPalindrome(string word)
        {
            var reversedWord = ReverseWord(word);
            return string.Equals(word, reversedWord, StringComparison.OrdinalIgnoreCase);
        }

        public static int CountVowels(string word)
        {
            int vowelCounter = 0;
            foreach (var letter in word.ToLower())
            {
                if ("aeiouáéíóú".Contains(letter))
                {
                    vowelCounter++;
                }
            }
            return vowelCounter;
        }
    }

}
