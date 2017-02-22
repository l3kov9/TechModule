namespace _02.RotateAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotateCount = int.Parse(Console.ReadLine());
            int[] resultList = new int[array.Length];

            for (int i = 0; i < rotateCount; i++)
            {
                RotateArray(array);
                for (int j = 0; j < resultList.Length; j++)
                {
                    resultList[j] += array[j];
                }
            }

            Console.WriteLine(string.Join(" ",resultList));
        }

        private static void RotateArray(int[] array)
        {
            int lastIndexOfArray = array[array.Length - 1];
            for (int i = array.Length-1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastIndexOfArray;
        }
    }
}
