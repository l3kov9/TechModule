namespace _10.СръбскоUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MusicCollection
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var musicCollection = new Dictionary<string, Dictionary<string, long>>();

            while (!input.Equals("End"))
            {
                var list = input.Split().ToList();
                var result = 0;
                var checkList = input.Split('@').ToList();
                if (checkList.Count == 2)
                {
                    if (list.Count >= 4 && int.TryParse(list[list.Count - 2], out result) && int.TryParse(list[list.Count - 1], out result))
                    {
                        var singer = checkList[0].Trim();
                        var venueList = checkList[1].Split().ToList();
                        venueList.Remove(list[list.Count - 2]);
                        venueList.Remove(list[list.Count - 1]);
                        var venue = string.Join(" ", venueList);

                        var ticketPrice = int.Parse(list[list.Count - 2]);
                        var ticketCount = int.Parse(list[list.Count - 1]);
                        long totalMoney = ticketCount * ticketPrice;

                        AddToCollection(musicCollection, venue, singer, totalMoney);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in musicCollection)
            {
                Console.WriteLine(kvp.Key);
                var result = kvp.Value.OrderByDescending(x => x.Value);
                foreach (var singerAndPrice in result)
                {
                    Console.WriteLine($"#  {singerAndPrice.Key} -> {singerAndPrice.Value}");
                }
            }
        }

        private static void AddToCollection(Dictionary<string, Dictionary<string, long>> musicCollection, 
            string venue, string singer, long totalMoney)
        {
            if (!musicCollection.ContainsKey(venue))
            {
                musicCollection[venue] = new Dictionary<string, long>();
            }
            if (!musicCollection[venue].ContainsKey(singer))
            {
                musicCollection[venue][singer] = 0;
            }
            musicCollection[venue][singer] += totalMoney;
        }
    }
}
