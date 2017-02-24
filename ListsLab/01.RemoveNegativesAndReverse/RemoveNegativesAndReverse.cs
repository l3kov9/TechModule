namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Reverse();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }

            if (list.Count > 0)
                Console.WriteLine(string.Join(" ", list));
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
