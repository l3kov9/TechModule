namespace _06.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequencesIfEqualElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 1;
            int maxCount = counter;
            int longestElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        longestElement = array[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < maxCount; i++)
            {
                result.Add(longestElement);
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
