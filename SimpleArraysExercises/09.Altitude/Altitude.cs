namespace _09.Altitude
{
    using System;
    public class Altitude
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split();
            double currentAltitude = double.Parse(array[0]);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == "up")
                {
                    currentAltitude += double.Parse(array[i + 1]);
                }
                else if (array[i] == "down")
                {
                    currentAltitude -= double.Parse(array[i + 1]);
                }
                if (currentAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine($"got through safely. current altitude: {currentAltitude}m");
        }
    }
}
