namespace _11.DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DragonArmy
    {
        public static void Main()
        {
            var totalDragons = int.Parse(Console.ReadLine());
            var dragonArmy = new Dictionary<string, SortedDictionary<string, Dictionary<string, double>>>();

            for (int i = 0; i < totalDragons; i++)
            {
                var list = Console.ReadLine().Split().ToList();

                var type = list[0];
                var name = list[1];
                var damage = (list[2].Equals("null"))? 45: int.Parse(list[2]);
                var health = (list[3].Equals("null")) ? 250 : int.Parse(list[3]);
                var armor = (list[4].Equals("null")) ? 10 : int.Parse(list[4]);

                AddDragonToTheArmy(dragonArmy, type, name, damage, health, armor);
            }

            foreach (var kvp in dragonArmy)
            {
                var averageDamage = 0.0;
                var averageHealth = 0.0;
                var averageArmor = 0.0;
                var type = kvp.Key;
                foreach (var nameAndStats in kvp.Value)
                {
                    averageDamage += dragonArmy[kvp.Key][nameAndStats.Key]["damage"];
                    averageHealth += dragonArmy[kvp.Key][nameAndStats.Key]["health"];
                    averageArmor += dragonArmy[kvp.Key][nameAndStats.Key]["armor"];
                }


                Console.WriteLine($"{type}::({(double)averageDamage/(double)kvp.Value.Count:f2}/{(double)averageHealth / (double)kvp.Value.Count:f2}/{(double)averageArmor / (double)kvp.Value.Count:f2})");
                foreach (var nameAndStats in kvp.Value)
                {
                    Console.WriteLine($@"-{nameAndStats.Key} -> damage: {dragonArmy[kvp.Key][nameAndStats.Key]["damage"]}, health: { dragonArmy[kvp.Key][nameAndStats.Key]["health"]}, armor: { dragonArmy[kvp.Key][nameAndStats.Key]["armor"]}");
                }
            }
        }

        private static void AddDragonToTheArmy(Dictionary<string, SortedDictionary<string, Dictionary<string, double>>> dragonArmy,
            string type, string name, double damage, double health, double armor)
        {
            if (!dragonArmy.ContainsKey(type))
            {
                dragonArmy[type] = new SortedDictionary<string, Dictionary<string, double>>();
            }
            if (!dragonArmy[type].ContainsKey(name))
            {
                dragonArmy[type][name] = new Dictionary<string, double>();
            }

            dragonArmy[type][name]["damage"] = damage;
            dragonArmy[type][name]["health"] = health;
            dragonArmy[type][name]["armor"] = armor;
        }
    }
}
