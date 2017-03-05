namespace _02.DictRef
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, int>();
            char[] seps = { '=' };

            while (!input.Equals("end"))
            {
                var list = input.Split(seps, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = list[0].Trim();
                var value = list[1].Trim();
                var result = 0;
                var isParsed = int.TryParse(value,out result);

                if (isParsed)
                {
                    dict[name] = int.Parse(list[1]);
                }
                else
                {
                    if (dict.ContainsKey(value))
                    {
                        dict[name] = dict[value];
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
