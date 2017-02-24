namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SplitByWordCasing
    {
        public static void Main()
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', '\'', ' ' };
            var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var word in text)
            {
                int lowerLetter = 0;
                int upperLetter = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] >= 'a' && word[i] <= 'z')
                    {
                        lowerLetter++;
                    }
                    else if(word[i]>='A' && word[i] <= 'Z')
                    {
                        upperLetter++;
                    }
                }

                if (word.Length == lowerLetter)
                {
                    lowerCase.Add(word);
                }
                else if (word.Length == upperLetter)
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ",lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
