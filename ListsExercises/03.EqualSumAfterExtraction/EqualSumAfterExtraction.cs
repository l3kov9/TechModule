namespace _03.EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            foreach (var num in firstList)
            {
                while (secondList.Contains(num))
                {
                    secondList.Remove(num);
                }
            }

            if (firstList.Sum() == secondList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {firstList.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstList.Sum()-secondList.Sum())}");
            }
        }
    }
}
