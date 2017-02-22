namespace _03.LastKNumbersSums
{
    using System;
    public class LastKNumbersSum
    {
        public static void Main()
        {
            int elements = int.Parse(Console.ReadLine());
            int previousElementsCount = int.Parse(Console.ReadLine());
            long[] array = new long[elements];
            array[0] = 1;

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = SumPrevElements(i - previousElementsCount, i - 1, array);
            }

            Console.WriteLine(string.Join(" ",array));
        }

        private static long SumPrevElements(int startingIndex, int finalIndex, long[] array)
        {
            for (int i = startingIndex; i <= finalIndex; i++)
            {
                if (i >= 0)
                {
                    array[finalIndex + 1] += array[i];
                }
            }
            return array[finalIndex+1];
        }
    }
}
