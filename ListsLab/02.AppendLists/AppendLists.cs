namespace _02.AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AppendLists
    {
        public static void Main()
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            lists.Reverse();
            List<int> result = new List<int>();
            char[] seps = { ' ' };
            List<int> finalList = new List<int>();
            
            foreach (var list in lists)
            {
                result = list.Split(seps, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                foreach (var num in result)
                {
                    finalList.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
