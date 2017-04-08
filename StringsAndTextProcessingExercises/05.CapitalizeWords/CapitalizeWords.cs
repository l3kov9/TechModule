namespace _05.CapitalizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CapitalizeWords
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                var separators = new[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' };

                var list = input.ToUpper().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
                var output = new List<string>();

                foreach (var word in list)
                {
                    output.Add(CapitalizedWord(word));
                }

                Console.WriteLine(string.Join(", ",output));

                input = Console.ReadLine();
            }
        }

        private static string CapitalizedWord(string word)
        {
            var sb = new StringBuilder();

            sb.Append(word[0]);
            word=word.ToLower();

            for (int i = 1; i < word.Length; i++)
            {
                sb.Append(word[i]);
            }

            return sb.ToString();
        }
    }
}
