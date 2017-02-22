namespace _05.RoundingNumbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var num in array)
            {
                Console.WriteLine("{0} => {1}",num,Math.Round(num,MidpointRounding.AwayFromZero));
            }
        }
    }
}
