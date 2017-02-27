namespace _04.SortArrayUsingBubbleSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SortArrayinBubbles
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bubbledList = new List<int>();

            while (list.Count>0)
            {
                int minElement = int.MaxValue;
                foreach (var num in list)
                {
                    if (num < minElement)
                    {
                        minElement = num;
                    }
                }
                bubbledList.Add(minElement);
                list.Remove(minElement);
            }

            Console.WriteLine(string.Join(" ",bubbledList));
        }
    }
}
