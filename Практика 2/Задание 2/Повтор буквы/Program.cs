namespace Повтор_буквы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку текста:");
            string text = Console.ReadLine();

            Dictionary<char, int> lettersCount = CountLetters(text);

            char mostFrequentLetter = FindMostFrequentLetter(lettersCount);

            int count = lettersCount[mostFrequentLetter];

            Console.WriteLine($"Буква '{mostFrequentLetter}' была употреблена {count} раз(а).");
        }

        static Dictionary<char, int> CountLetters(string text)
        {
            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            foreach (char c in text)
            {
                if (Char.IsLetter(c))
                {
                    char letter = Char.ToLower(c);
                    if (lettersCount.ContainsKey(letter))
                    {
                        lettersCount[letter]++;
                    }
                    else
                    {
                        lettersCount[letter] = 1;
                    }
                }
            }

            return lettersCount;
        }

        static char FindMostFrequentLetter(Dictionary<char, int> lettersCount)
        {
            char mostFrequentLetter = '\0';
            int maxCount = 0;

            foreach (KeyValuePair<char, int> pair in lettersCount)
            {
                if (pair.Value > maxCount)
                {
                    mostFrequentLetter = pair.Key;
                    maxCount = pair.Value;
                }
            }

            return mostFrequentLetter;
        }
    }
}