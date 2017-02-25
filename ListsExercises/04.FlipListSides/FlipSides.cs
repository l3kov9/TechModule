namespace _04.FlipListSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FlipSides
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var firstElement = list[0];
            var lastElement = list[list.Count - 1];
            var middleElement = list[list.Count / 2];

            if (list.Count % 2 == 1)
            {
                list.RemoveAt(list.Count / 2);
                list.RemoveAt(0);
                list.RemoveAt(list.Count - 1);
                list.Reverse();
                list.Add(lastElement);
                list.Insert(0, firstElement);
                list.Insert(list.Count / 2 , middleElement);
            }
            else
            {
                list.Remove(list[0]);
                list.Remove(list[list.Count - 1]);
                list.Reverse();
                list.Add(lastElement);
                list.Insert(0, firstElement);
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
