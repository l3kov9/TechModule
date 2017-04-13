namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToList();
            
            var songs = Console.ReadLine().Split(',').Select(x=>x.Trim()).ToList();
           
            var playList = new Dictionary<string, SortedSet<string>>();
            var command = Console.ReadLine();

            while (!command.Equals("dawn"))
            {
                var list = command.Split(',').ToList();

                var participant = list[0].Trim();
                var song = list[1].Trim();
                var award = list[2].Trim();

                if (names.Contains(participant) && songs.Contains(song))
                {
                    AddToDictionary(playList, participant, award);
                }

                command = Console.ReadLine();
            }


            if (playList.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var kvp in playList.OrderByDescending(x => x.Value.Count).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value.Count} awards");
                    foreach (var award in kvp.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }

        private static void AddToDictionary(Dictionary<string, SortedSet<string>> playList, string participant, string award)
        {
            if (!playList.ContainsKey(participant))
            {
                playList[participant] = new SortedSet<string>();
            }
            if (!playList[participant].Contains(award))
            {
                playList[participant].Add(award);
            }
        }
    }
}
