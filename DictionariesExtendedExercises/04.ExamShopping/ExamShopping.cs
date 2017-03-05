namespace _04.ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ExamShopping
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().ToList();
            var dict = new Dictionary<string, int>();

            while (!list[0].Equals("exam"))
            {
                if (list[0].Equals("stock"))
                {
                    if (dict.ContainsKey(list[1]))
                    {
                        dict[list[1]] += int.Parse(list[2]);
                    }
                    else
                    {
                        dict[list[1]] = int.Parse(list[2]);
                    }
                }

                if (list[0].Equals("buy"))
                {
                    if (dict.ContainsKey(list[1]))
                    {
                        if (dict[list[1]] > 0)
                        {
                            dict[list[1]] -= int.Parse(list[2]);
                        }
                        else
                        {
                            Console.WriteLine($"{list[1]} out of stock");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{list[1]} doesn't exist");
                    }
                }
                
                list = Console.ReadLine().Split().ToList();
            }

            foreach (var kvp in dict)
            {
                var value = kvp.Value;
                if (value > 0)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }
        }
    }
}
