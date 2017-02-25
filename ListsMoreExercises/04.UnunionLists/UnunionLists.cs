namespace _04.UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class UnunionLists
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandList = Console.ReadLine().Split().Select(int.Parse).ToList();
                foreach (var num in commandList)
                {
                    if (list.Contains(num))
                    {
                        while (list.Contains(num))
                        {
                            list.Remove(num);
                        }
                    }
                    else
                    {
                        list.Add(num);
                    }
                    
                }
            }
            list.Sort();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
