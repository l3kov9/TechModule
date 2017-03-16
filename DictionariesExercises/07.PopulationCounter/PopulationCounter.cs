namespace _07.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var worldPopulation = new Dictionary<string, Dictionary<string, double>>();

            while (!input.Equals("report"))
            {
                var list = input.Split('|').ToList();
                var country = list[1];
                var town = list[0];
                var population = double.Parse(list[2]);

                AddToWorldPopulationDictionary(worldPopulation, country, town, population);

                input = Console.ReadLine();
            }

            var result = worldPopulation.OrderByDescending(x => x.Value.Values.Sum());

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} (total population: {kvp.Value.Values.Sum()})");
                var secondDict = kvp.Value.OrderByDescending(x => x.Value);
                foreach (var townAndPopulation in secondDict)
                {
                    Console.WriteLine($"=>{townAndPopulation.Key}: {townAndPopulation.Value}");
                }
            }
        }

        private static void AddToWorldPopulationDictionary(Dictionary<string, Dictionary<string, double>> worldPopulation,
            string country, string town, double population)
        {
            if (!worldPopulation.ContainsKey(country))
            {
                worldPopulation[country] = new Dictionary<string, double>();
            }
            if (!worldPopulation[country].ContainsKey(town))
            {
                worldPopulation[country][town] = 0;
            }

            worldPopulation[country][town] += population;
        }
    }
}