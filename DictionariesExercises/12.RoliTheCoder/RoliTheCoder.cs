namespace _12.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RoliTheCoder
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var idTracks = new Dictionary<int, string>();
            var eventDictionary = new Dictionary<string, List<string>>();

            while (!input.Equals("Time for Code"))
            {
                var list = input.Split().ToList();
                var result = 0;
                var participantList = new List<string>();

                if(list.Count>=2 && int.TryParse(list[0],out result) && list[1].Substring(0, 1).Equals("#"))
                {
                    AddToIdAndTrackDictionary(idTracks, int.Parse(list[0]), list[1]);
                    for (int i = 2; i < list.Count; i++)
                    {
                        participantList.Add(list[i]);
                    }

                    AddToEventDictionary(eventDictionary, participantList,list[1]);
                }

                input = Console.ReadLine();
            }

            

            foreach (var kvp in eventDictionary.OrderByDescending(x=>x.Value.Count))
            {
                if (idTracks.ContainsValue(kvp.Key))
                { 
                    Console.WriteLine($"{kvp.Key.Substring(1)} - {eventDictionary[kvp.Key].Distinct().ToList().Count}");
                    foreach (var name in eventDictionary[kvp.Key].Distinct().ToList().OrderBy(x=>x))
                    {
                        Console.WriteLine(name);
                    }
                }
                
            }
            
        }

        private static void AddToEventDictionary(Dictionary<string, List<string>> eventDictionary, List<string> participantList,string name)
        {
            if (!eventDictionary.ContainsKey(name))
            {
                eventDictionary[name] = new List<string>();
            }
            eventDictionary[name].AddRange(participantList);
        }

        private static void AddToIdAndTrackDictionary(Dictionary<int, string> idTracks, int id, string eventName)
        {
            if (!idTracks.ContainsKey(id))
            {
                idTracks[id] = eventName;
            }
        }
    }
}
