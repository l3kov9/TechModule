namespace _03.BigFactorial
{
    using System;
    using System.Numerics;
    public class BigFactorial
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
