namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Shellbound
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, HashSet<int>>();

            while (!input.Equals("Aggregate"))
            {
                var list = input.Split().ToList();
                var town = list[0];
                var shell = list[1];

                AddToDictionary(town, shell, dict);

                input = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(", ",kvp.Value)} ({kvp.Value.Sum()-(int)((double)kvp.Value.Sum()/kvp.Value.Count)})");
            }
        }

        private static void AddToDictionary(string town, string shell, Dictionary<string, HashSet<int>> dict)
        {
            if (!dict.ContainsKey(town))
            {
                dict[town] = new HashSet<int>();
            }

            dict[town].Add(int.Parse(shell));
        }
    }
}
