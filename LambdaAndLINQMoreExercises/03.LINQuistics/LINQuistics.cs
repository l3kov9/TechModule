namespace _03.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LINQuistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var linqQuistic = new Dictionary<string, HashSet<string>>();

            while (!input.Equals("exit"))
            {
                var list = input.Split('.').ToList();
                var collection = list[0];
                var result = 0;

                if(list.Count==1 && !int.TryParse(collection,out result) && linqQuistic.ContainsKey(collection))
                {
                    foreach (var method in linqQuistic[collection].OrderByDescending(x=>x.Length).ThenByDescending(x=>!x.Equals(x)))
                        //TODO: print methods in desc order by length,then by unique symbols
                    {
                        Console.WriteLine($"* {method}");
                    }
                }
                else if(list.Count == 1 && int.TryParse(collection, out result))
                {
                    int count = 0;
                    foreach (var kvp in linqQuistic.OrderByDescending(x=>x.Value.Count))
                    {
                        foreach (var item in kvp.Value.OrderBy(x=>x.Length))
                        {
                            Console.WriteLine($"* {item}");
                            count++;
                            if (count == int.Parse(collection))
                                break;
                        }
                        break;
                    }
                }
                else
                {
                    list.Remove(collection);
                    AddToLinq(linqQuistic, collection, list);
                }

                input = Console.ReadLine();
            }

            var commandList = Console.ReadLine().Split().ToList();
            var finalMethod = commandList[0];
            var finalCollection = commandList[1];
            if (finalCollection.Equals("all"))
            {
                foreach (var kvp in linqQuistic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value.Min()))
                {
                    if (kvp.Value.Contains(finalMethod+"()"))
                    {
                        foreach (var method in kvp.Value.OrderByDescending(x=>x.Length))
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                }
            }
            else if(finalCollection.Equals("collection"))
            {
                foreach (var kvp in linqQuistic.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value.Min()))
                {
                    if (kvp.Value.Contains(finalMethod + "()"))
                    {
                        
                            Console.WriteLine($"* {kvp.Value}");
                    }
                }
            }
        }

        private static void AddToLinq(Dictionary<string, HashSet<string>> linqQuistic, string collection, List<string> list)
        {
            if (!linqQuistic.ContainsKey(collection))
            {
                linqQuistic[collection] = new HashSet<string>();
            }

            foreach (var method in list)
            {
                linqQuistic[collection].Add(method);
            }
        }
    }
}
