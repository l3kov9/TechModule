namespace _03.Flatten_Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FlattenDictionary
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, Dictionary<string, string>>();
            var flattenDictionary = new Dictionary<string, List<string>>();

            while (!input.Equals("end"))
            {
                var list = input.Split().ToList();
                if (list[0].Equals("flatten"))
                {
                    var flattenKey = list[1];
                    var flattenList = new List<string>();
                    foreach (var item in dictionary[flattenKey])
                    {
                        flattenList.Add($"{item.Key}{item.Value}");
                    }

                    if (!flattenDictionary.ContainsKey(flattenKey))
                    {
                        flattenDictionary[flattenKey] = new List<string>();
                    }
                    flattenDictionary[flattenKey].AddRange(flattenList);

                    dictionary.Remove(flattenKey);
                }
                else
                {
                    var key = list[0];
                    var innerKey = list[1];
                    var innerValue = list[2];

                    AddToDictionary(dictionary, key, innerKey, innerValue);
                }
                input = Console.ReadLine();
            }

            foreach (var kvp in dictionary.OrderByDescending(x=>x.Key.Length))
            {
                Console.WriteLine($"{kvp.Key}");
                int i = 1;
                foreach (var item in kvp.Value.OrderBy(x=>x.Key.Length))
                {
                    Console.WriteLine($"{i}. {item.Key} - {item.Value}");
                    i++;
                }
                if (flattenDictionary.ContainsKey(kvp.Key))
                {
                    foreach (var item in flattenDictionary[kvp.Key])
                    {
                        Console.WriteLine($"{i}. {item}");
                        i++;
                    }
                }
            }
        }

        private static void AddToDictionary(Dictionary<string, Dictionary<string, string>> dictionary,
                                            string key, string innerKey, string innerValue)
        {
            if (!dictionary.ContainsKey(key))
            {
                dictionary[key] = new Dictionary<string, string>();
            }
            if (!dictionary[key].ContainsKey(innerKey))
            {
                dictionary[key][innerKey] = string.Empty;
            }

            dictionary[key][innerKey] = innerValue;
        }
    }
}
