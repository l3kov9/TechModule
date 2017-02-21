namespace _02.CountOfNegativeElementsInArray
{
    using System;
    public class CountOfNegativeElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int countNegativeNums = 0;

            for (int i = 0; i <array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

                if (array[i] < 0)
                {
                    countNegativeNums++;
                }
            }

            Console.WriteLine(countNegativeNums);
        }
    }
}
