namespace _03.ReverseArrayIn_place
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ReverseArray
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count/2; i++)
            {
                var currentElement = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = currentElement;
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
