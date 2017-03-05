namespace _01.LetterRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LetterRepetition
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (dict.ContainsKey(letter))
                {
                    dict[letter]++;
                }
                else
                {
                    dict[letter] = 1;
                }
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
