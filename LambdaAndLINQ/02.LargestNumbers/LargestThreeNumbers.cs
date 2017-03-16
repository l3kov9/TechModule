namespace _02.LargestNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            list.Reverse();

            if (list.Count <= 3)
            {
                Console.WriteLine(string.Join(" ",list));
            }
            else
            {
                Console.WriteLine(string.Join(" ",list.Take(3)));
            }
        }
    }
}
