namespace _11.EqualSums
{
    using System;
    using System.Linq;

    public class EqualSum
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isEqual = false;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = SumElements(array,0, i - 1);
                int rightSum = SumElements(array, i + 1, array.Length - 1);

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }

            if (isEqual == false)
            {
                Console.WriteLine("no");
            }
        }

        private static int SumElements(int[] array, int startIndex, int finalIndex)
        {
            int result = 0;
            for (int i = startIndex; i <= finalIndex; i++)
            {
                result += array[i];
            }

            return result;
        }
    }
}
