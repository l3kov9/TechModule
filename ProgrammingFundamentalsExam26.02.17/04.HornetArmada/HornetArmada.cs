namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var soldiers = new Dictionary<int, Dictionary<string, Dictionary<string, int>>>();

            var pattern = @"(\d+)\s+=\s+(\w+)\s+->\s+(\w+):(\d+)";
            var regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var matches = regex.Matches(input);

                var lastActivity = 0;
                var legionName = string.Empty;
                var soldierType = string.Empty;
                var soldierCount = 0;

                foreach (Match match in matches)
                {
                    lastActivity = int.Parse(match.Groups[1].Value);
                    legionName = match.Groups[2].Value;
                    soldierType = match.Groups[3].Value;
                    soldierCount = int.Parse(match.Groups[4].Value);
                }

                AddToDictionary(soldiers, lastActivity, legionName, soldierType, soldierCount);
            }

            var command = Console.ReadLine().Split('\\') ;
            if (command.Length == 1)
            {
                var soldierType = command[0];
            }
            else
            {
                var activity = int.Parse(command[0]);
                var soldierType = command[1];

                //{lastActivity} = {legionName} -> {soldierType}:{soldierCount}

                foreach (var lastActivityLegionName in soldiers.Where(x=>x.Key<activity))
                {
                    foreach (var legionNameSoldierType in lastActivityLegionName.Value)
                    {
                        foreach (var soldierTypeCount in legionNameSoldierType.Value)
                        {
                            Console.WriteLine(soldierTypeCount.Key);
                        }
                    }
                }
            }

        }

        private static void AddToDictionary(Dictionary<int, Dictionary<string, Dictionary<string, int>>> soldiers,
            int lastActivity, string legionName, string soldierType, int soldierCount)
        {
            if (!soldiers.ContainsKey(lastActivity))
            {
                soldiers[lastActivity] = new Dictionary<string, Dictionary<string, int>>();
            }

            if (!soldiers[lastActivity].ContainsKey(legionName))
            {
                soldiers[lastActivity][legionName] = new Dictionary<string, int>();
            }

            if (!soldiers[lastActivity][legionName].ContainsKey(soldierType))
            {
                soldiers[lastActivity][legionName][soldierType] = 0;
            }
            soldiers[lastActivity][legionName][soldierType] += soldierCount;
        }
    }
}
