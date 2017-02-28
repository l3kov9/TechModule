namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HornetAssault
    {
        public static void Main()
        {
            var bees = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornetsSum = hornets.Sum();

            for (int i = 0; i < bees.Count; i++)
            {
                if (hornets.Count < 1)
                {
                    break;
                }

                bees[i] -= hornetsSum;
                if (bees[i] >= 0)
                {
                    hornetsSum -= hornets[0];
                    hornets.RemoveAt(0);
                }
            }

            var maxCountBees = bees.Max();
            if (maxCountBees > 0)
            {
                var finalBeesList = new List<long>();
                foreach (var num in bees)
                {
                    if (num > 0)
                    {
                        finalBeesList.Add(num);
                    }
                }
                Console.WriteLine(string.Join(" ",finalBeesList));
            }
            else
            {
                Console.WriteLine(string.Join(" ",hornets));
            }
        }
    }
}
