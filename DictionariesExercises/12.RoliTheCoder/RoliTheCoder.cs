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
            var eventDictionary = new Dictionary<int, Dictionary<string, List<string>>>();

            while (!input.Equals("Time for Code"))
            {
                var list = input.Split().ToList();
                var result = 0;

                if (list.Count >= 2 && int.TryParse(list[0], out result) && list[1].Substring(0, 1).Equals("#"))
                {
                    var id = int.Parse(list[0]);
                    var eventName = list[1];
                    list.RemoveAt(0);
                    list.RemoveAt(0);
                    var isRightFormat = true;

                    foreach (var word in list)
                    {
                        if (!word.Substring(0, 1).Equals("@") && word.Length <= 1)
                        {
                            isRightFormat = false;
                        }
                    }

                    if (isRightFormat)
                    {
                        if (!eventDictionary.ContainsKey(id))
                        {
                            eventDictionary[id] = new Dictionary<string, List<string>>();
                        }

                        eventDictionary[id][eventName] = new List<string>();

                        foreach (var word in list)
                        {
                            eventDictionary[id][eventName].Add(word);
                        }

                    }
                }


                input = Console.ReadLine();
            }

            foreach (var item in eventDictionary.Values.OrderByDescending(x=>x.Values.Count))
            {
                var result = item.OrderByDescending(x => x.Key);
                foreach (var kvp in result)
                {
                    Console.WriteLine(kvp.Key);
                }
            }

            
        }
    }
}
