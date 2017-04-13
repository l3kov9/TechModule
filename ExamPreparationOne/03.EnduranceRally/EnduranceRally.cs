namespace _03.EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var trackZones = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
            var checkPoints = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();

            foreach (var driver in drivers)
            {
                decimal fuel = (int)driver[0];

                for (int i = 0; i < trackZones.Count; i++)
                {
                    if (checkPoints.Contains(i))
                    {
                        fuel += trackZones[i];
                    }
                    else
                    {
                        fuel -= trackZones[i];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }
                if(fuel>0)
                Console.WriteLine($"{driver} - fuel left {fuel:f2}");
            }
        }
    }
}