namespace _03.MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MixedPhone
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new SortedDictionary<string, long>();

            while (!input.Equals("Over"))
            {
                var list = input.Split(':').ToList();

                var name = list[0].Trim();
                var value = list[1].Trim();
                long result = 0;

                var isParsed = long.TryParse(value, out result);
                if (isParsed)
                {
                    dict[name] = long.Parse(value);
                }
                else
                {
                    dict[value] = long.Parse(name);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
