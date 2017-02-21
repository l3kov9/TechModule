namespace _03.CountOfGivenElementInArray
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int countElementRepeatTimes = 0;

            foreach (var num in array)
            {
                if (num == element)
                {
                    countElementRepeatTimes++;
                }
            }

            Console.WriteLine(countElementRepeatTimes);
        }
    }
}
