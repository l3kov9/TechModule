namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CountNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var arrayOfIntegers = new int[1001];

            for (int i = 0; i < list.Count; i++)
            {
                arrayOfIntegers[list[i]]++;
            }

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] > 0)
                {
                    Console.WriteLine($"{i} -> {arrayOfIntegers[i]}");
                }
            }
        }
    }
}
