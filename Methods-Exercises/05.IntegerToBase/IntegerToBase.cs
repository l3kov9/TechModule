namespace _05.IntegerToBase
{
    using System;
    public class IntegerToBase
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string numberToBase = NumberToBase(number, toBase);
            Console.WriteLine(numberToBase);
        }

        private static string NumberToBase(int number, int toBase)
        {
            string result = string.Empty;
            while (number>0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
