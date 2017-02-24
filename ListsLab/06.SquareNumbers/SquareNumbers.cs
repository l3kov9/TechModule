namespace _06.SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SquareNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            list.Reverse();
            var result = new List<int>();

            foreach (var num in list)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
