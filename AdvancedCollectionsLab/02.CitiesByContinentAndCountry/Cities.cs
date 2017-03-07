namespace _02.CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Cities
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var worldMap = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split().ToList();
                var continent = list[0];
                var country = list[1];
                var town = list[2];

                AddToWorldMap(worldMap, continent, country, town);
            }

            foreach (var pair in worldMap)
            {
                var continent = pair.Key;
                var nestedDictionary = pair.Value;
                Console.WriteLine($"{continent}:");

                foreach (var countryAndTown in nestedDictionary)
                {
                    Console.WriteLine($"{countryAndTown.Key} -> {string.Join(", ",countryAndTown.Value)}");
                }
            }
        }

        private static void AddToWorldMap(Dictionary<string, Dictionary<string, List<string>>> worldMap,
            string continent, string country, string town)
        {
            if (!worldMap.ContainsKey(continent))
            {
                worldMap[continent] = new Dictionary<string, List<string>>();
            }
            if (!worldMap[continent].ContainsKey(country))
            {
                worldMap[continent][country] = new List<string>();
            }

            worldMap[continent][country].Add(town);
        }
    }
}
