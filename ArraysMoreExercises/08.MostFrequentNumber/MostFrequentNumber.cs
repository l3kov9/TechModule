namespace _08.MostFrequentNumber
{
    using System;
    using System.Linq;

    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int maxCount = 0;
            int mostFrequentNumber = array[0];

            foreach (var num in array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (num == array[i])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            mostFrequentNumber = num;
                        }
                    }
                }
                count = 0;
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
