namespace _06.PowerPlants
{
    using System;
    using System.Linq;
    public class PowerPlants
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countSeason = 0;
            int totalDays = 0;

            for (int i = 0; i < array.Length; i++)
            {
                totalDays++;
                array[i]++;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] > 0)
                    {
                        array[j]--;
                    }
                }

                if (array.Sum() == 0)
                {
                    Console.WriteLine($"survived {totalDays} days ({countSeason} seasons)");
                    return;
                }

                if (i == array.Length-1)
                {
                    countSeason++;
                    for (int k = 0; k < array.Length; k++)
                    {
                        if(array[k]>0)
                               array[k]++;
                    }
                    i = 0;
                }
            }
        }
    }
}
