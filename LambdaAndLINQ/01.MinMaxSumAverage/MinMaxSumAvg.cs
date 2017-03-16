namespace _01.MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MinMaxSumAvg
    {

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");
        }
    }
}
