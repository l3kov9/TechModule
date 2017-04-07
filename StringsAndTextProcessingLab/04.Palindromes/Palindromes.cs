namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ', ',', '?', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var listOfPalindromes = new SortedSet<string>();

            foreach (var word in text)
            {
                if (isPalindrome(word))
                {
                    listOfPalindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",listOfPalindromes));
        }

        private static bool isPalindrome(string word)
        {
            var reversedWord = new StringBuilder();

            for (int i = word.Length-1; i >= 0; i--)
            {
                reversedWord.Append(word[i]);
            }

            return word.Equals(reversedWord.ToString());
        }
    }
}
