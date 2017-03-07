namespace _04.GroupContinentsCountriesAndCities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class GroupingWorldMap
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var worldMap = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var continent = input[0];
                var country = input[1];
                var town = input[2];

                AddToWorldMap(worldMap, continent, country, town);
            }

            foreach (var kvp in worldMap)
            {
                Console.WriteLine($"{kvp.Key}:");
                foreach (var countryAndTown in kvp.Value)
                {
                    Console.WriteLine($"  {countryAndTown.Key} -> {string.Join(", ",countryAndTown.Value)}");
                }
            }
        }

        private static void AddToWorldMap(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> worldMap,
            string continent, string country, string town)
        {
            if (!worldMap.ContainsKey(continent))
            {
                worldMap[continent] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!worldMap[continent].ContainsKey(country))
            {
                worldMap[continent][country] = new SortedSet<string>();
            }

            worldMap[continent][country].Add(town);
        }
    }
}
