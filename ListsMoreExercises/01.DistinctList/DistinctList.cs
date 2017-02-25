namespace _01.DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DistinctList
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list=list.Distinct().ToList();
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
