namespace _03.ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ForumTopics
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var topicDictionary = new Dictionary<string, HashSet<string>>();
            var seps = new char[] { ',', ' ', '>','-' };

            while (!input.Equals("filter"))
            {
                var list = input.Split(seps, StringSplitOptions.RemoveEmptyEntries).ToList();
                var topic = list[0].Trim();
                if (!topicDictionary.ContainsKey(topic))
                {
                    topicDictionary[topic] = new HashSet<string>();
                }
                for (int i = 1; i < list.Count; i++)
                {
                    topicDictionary[topic].Add(list[i]);
                }

                input = Console.ReadLine();
            }

            var tagsSequence = Console.ReadLine().Split(seps, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var kvp in topicDictionary)
            {
                var counter = 0;
                foreach (var tag in tagsSequence)
                {
                    if (kvp.Value.Contains(tag))
                    {
                        counter++;
                    }
                }

                if (counter == tagsSequence.Count)
                {
                    Console.WriteLine($"{kvp.Key} | #{string.Join(", #",kvp.Value)}");
                }
            }
        }
    }
}
