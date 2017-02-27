namespace _06.Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Batteries
    {
        public static void Main()
        {
            var batteryPower = Console.ReadLine().Split().Select(double.Parse).ToList();
            var usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToList();
            var stressTestHour = int.Parse(Console.ReadLine());
            var capacity = new List<double>();
            foreach (var num in batteryPower)
            {
                capacity.Add(num);
            }

            for (int i = 0; i < stressTestHour; i++)
            {
                for (int j = 0; j < batteryPower.Count; j++)
                {
                    batteryPower[j] -= usagePerHour[j];
                }
            }

            for (int i = 0; i < batteryPower.Count; i++)
            {
                if (batteryPower[i] > 0)
                {
                    Console.WriteLine($"Battery {i+1}: {batteryPower[i]:f2} mAh ({(double)batteryPower[i]/capacity[i]*100.0:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i+1}: dead (lasted {Math.Ceiling(capacity[i]/usagePerHour[i])} hours)");
                }
            }
        }
    }
}
