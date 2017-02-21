namespace _04.CountOccurrencesOfLargerNumbersInArray
{
    using System;
    using System.Linq;

    public class CountOccurencesOfLargerNumbers
    {
        public static void Main()
        {
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            int countBiggerElements = 0;

            foreach (var num in array)
            {
                if (num > p)
                {
                    countBiggerElements++;
                }
            }

            Console.WriteLine(countBiggerElements);
        }
    }
}
