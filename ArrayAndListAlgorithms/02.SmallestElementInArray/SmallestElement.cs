namespace _02.SmallestElementInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SmallestElement
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var smallestElement = int.MaxValue;

            foreach (var num in list)
            {
                if (num < smallestElement)
                {
                    smallestElement = num;
                }
            }

            Console.WriteLine(smallestElement);
        }
    }
}
