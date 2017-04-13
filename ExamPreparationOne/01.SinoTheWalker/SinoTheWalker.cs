namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var neededSteps = decimal.Parse(Console.ReadLine());
            var timePerStep = decimal.Parse(Console.ReadLine());

            int totalSeconds = (int)(timePerStep * neededSteps %(60*60*24));
            leavingTime = leavingTime.AddSeconds(totalSeconds);

            Console.WriteLine($"Time Arrival: {leavingTime:HH:mm:ss}");
        }
    }
}
