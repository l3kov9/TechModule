namespace _01.HornetWings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceFor1000Flaps = double.Parse(Console.ReadLine());
            var contestantEndurance = int.Parse(Console.ReadLine());

            var totalDistance = (wingFlaps / 1000.0) * distanceFor1000Flaps;
            var totalSeconds = wingFlaps / 100.0;
            totalSeconds += (int)Math.Floor(wingFlaps / (double)contestantEndurance)* 5;

            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine(totalSeconds+" s.");
        }
    }
}
