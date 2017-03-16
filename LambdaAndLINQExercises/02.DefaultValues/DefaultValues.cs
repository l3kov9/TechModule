namespace _02.DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();

            while (!input.Equals("end"))
            {
                var list = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var key = list[0];
                var value = list[list.Count - 1];
                dictionary[key] = value;
                input = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();
            foreach (var kvp in dictionary.Where(x=>!x.Value.Equals("null")).OrderByDescending(x=>x.Value.Length))
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
            foreach (var kvp in dictionary.Where(x => x.Value.Equals("null")))
            {
                Console.WriteLine($"{kvp.Key} <-> {defaultValue}");
            }
        }
    }
}
