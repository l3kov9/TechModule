namespace _01.SerializeString
{
    using System;
    using System.Collections.Generic;

    public class SerializeString
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<char, List<int>>();

            foreach (var letter in input)
            {
                if (!dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = new List<int>();

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i].Equals(letter))
                        {
                            dictionary[letter].Add(i);
                        }
                    }
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}:{string.Join("/",kvp.Value)}");
            }
        }
    }
}
