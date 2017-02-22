namespace _07.MaxSequenceOfIncreasingElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int maxCounter = counter;
            List<int> maxIncreasingElements = new List<int>();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        maxIncreasingElements.Clear();
                        UpdateListOfIncreasingElements(maxIncreasingElements, array, i, i - counter+1);
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            Console.WriteLine(string.Join(" ", maxIncreasingElements));

        }

        private static void UpdateListOfIncreasingElements(List<int> maxIncreasingElements, int[] array, int finalIndex, int startIndex)
        {
            maxIncreasingElements.Clear();
            for (int i = startIndex; i <= finalIndex; i++)
            {
                maxIncreasingElements.Add(array[i]);
            }
        }
    }
}
