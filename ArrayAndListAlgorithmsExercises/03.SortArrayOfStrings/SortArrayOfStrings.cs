namespace _03.SortArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SortArrayOfStrings
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().ToList();
            list.Sort();
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
