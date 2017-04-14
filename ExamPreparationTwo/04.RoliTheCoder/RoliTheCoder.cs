namespace _04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var outputDictionary = new Dictionary<string, List<string>>();
            var validationDictionary = new Dictionary<int, string>();

            while (!input.Equals("Time for Code"))
            {
                var list = input.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToList();
                var result = 0;
                var id = 0;

                if (list.Count < 2)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (int.TryParse(list[0], out result))
                {
                     id = int.Parse(list[0]);
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }

                var eventName = list[1];
                if (eventName.Substring(0, 1) != "#")
                {
                    input = Console.ReadLine();
                    continue;
                }

                var participants = list.Skip(2).ToList();

                var invalidParticipant = false;

                foreach (var participant in participants)
                {
                    if (participant.Substring(0, 1) != "@")
                    {
                        invalidParticipant = true;
                    }
                }

                if (invalidParticipant)
                {
                    input = Console.ReadLine();
                    continue;
                }

                AddToDictionary(outputDictionary,validationDictionary, id, eventName, participants);


                input = Console.ReadLine();
            }

            foreach (var kvp in outputDictionary.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{kvp.Key.Substring(1)} - {kvp.Value.Count}");
                foreach (var participant in kvp.Value.OrderBy(x=>x))
                {
                    Console.WriteLine(participant);
                }
            }
        }

        private static void AddToDictionary(Dictionary<string, List<string>> outputDictionary,
            Dictionary<int,string> validationDictionary,
            int id, string eventName, List<string> participants)
        {
            if (!validationDictionary.ContainsKey(id))
            {
                validationDictionary[id] = eventName;
            }

            if(!outputDictionary.ContainsKey(eventName) && validationDictionary[id] == eventName)
            {
                outputDictionary[eventName] = new List<string>();
            }

            if(outputDictionary.ContainsKey(eventName) && validationDictionary[id] == eventName)
            {
                outputDictionary[eventName].AddRange(participants);
                outputDictionary[eventName]=outputDictionary[eventName].Distinct().ToList();
            }
        }
    }
}
