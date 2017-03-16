namespace _09.LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LegendaryFarming
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var farming = new Dictionary<string, double>();

            while (true)
            {
                var list = input.Split().ToList();
                for (int i = 1; i < list.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        AddToFarmingDictionary(farming,list[i],list[i-1]);
                    }

                    if (farming.ContainsKey("shards") && farming["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        farming["shards"] -= 250;
                        PrintFinalResult(farming);
                        return;
                    }
                    else if (farming.ContainsKey("fragments") && farming["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        farming["fragments"] -= 250;
                        PrintFinalResult(farming);
                        return;
                    }
                    else if (farming.ContainsKey("motes") && farming["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        farming["motes"] -= 250;
                        PrintFinalResult(farming);
                        return;
                    }
                }
                
                input = Console.ReadLine();
            }
        }

        private static void PrintFinalResult(Dictionary<string, double> farming)
        {
            if (!farming.ContainsKey("motes"))
            {
                farming["motes"] = 0;
            }
            if (!farming.ContainsKey("fragments"))
            {
                farming["fragments"] = 0;
            }
            if (!farming.ContainsKey("shards"))
            {
                farming["shards"] = 0;
            }
            var keyMaterials = farming
                .OrderByDescending(x => x.Value)
                .ThenBy(x=>x.Key)
                .Where(x => x.Key.Equals("motes") || x.Key.Equals("fragments") || x.Key.Equals("shards"));
            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            var junkMaterial=farming.
                OrderBy(x=>x.Key)
                .Where(x => !x.Key.Equals("motes") && !x.Key.Equals("fragments") && !x.Key.Equals("shards"));
            foreach (var kvp in junkMaterial)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        private static void AddToFarmingDictionary(Dictionary<string, double> farming, string material, string quantity)
        {
            material = material.ToLower();

            if (!farming.ContainsKey(material))
            {
                farming[material] = 0;
            }

            farming[material] += (double.Parse(quantity));
        }
    }
}
