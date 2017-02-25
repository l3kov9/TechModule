namespace _05.TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TearListInHalf
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var firstHalf = list.Take(list.Count / 2).ToList();
            var secondHalf = list.Skip(list.Count / 2).ToList();
            int indexOfAdding = 0;

            foreach (var num in secondHalf)
            {
                int firstDigit = num / 10;
                int secondDigit = num % 10;

                firstHalf.Insert(indexOfAdding, firstDigit);
                firstHalf.Insert(indexOfAdding + 2, secondDigit);
                indexOfAdding += 3;
            }

            Console.WriteLine(string.Join(" ",firstHalf));
        }
    }
}
