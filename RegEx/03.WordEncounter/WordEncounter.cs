namespace _03.WordEncounter
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class WordEncounter
    {
        public static void Main()
        {
            var filter = Console.ReadLine();

            var asciCode = filter.Substring(0, 1);
            var digit = int.Parse(filter.Substring(1));
            var list = new List<string>();

            var sentence = Console.ReadLine();

            while (!sentence.Equals("end"))
            {
                var isValid = CheckForValidation(sentence);
                if (isValid)
                {
                    var regex = new Regex("(\\w+)");
                    var matches = regex.Matches(sentence);

                    foreach (Match word in matches)
                    {
                        var counter = 0;
                        var text = word.Value;
                        foreach (var letter in text)
                        {
                            if (letter.Equals(Convert.ToChar(asciCode)))
                            {
                                counter++;
                            }
                        }
                        if (counter >= digit)
                        {
                            list.Add(word.Value);
                        }
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",list));
        }

        private static bool CheckForValidation(string sentence)
        {
            var pattern = "^[A-Z].+([\\.\\?!])$";
            var regex = new Regex(pattern);

            if (regex.IsMatch(sentence))
            {
                return true;
            }
            else
                return false;
        }
    }
}
