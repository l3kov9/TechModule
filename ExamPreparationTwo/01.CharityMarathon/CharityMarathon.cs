namespace _01.CharityMarathon
{
    using System;

    public class CharityMarathon
    {
        public static void Main()
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var runners = int.Parse(Console.ReadLine());
            var lapsPerRunner = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            long totalLaps = Math.Min((marathonDays * trackCapacity),runners)*lapsPerRunner;
            decimal totalMoney = (totalLaps * trackLength/1000.0m) * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
