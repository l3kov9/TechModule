namespace _6.PrimeChecker
{
    using System;
    public class PrimeChecker
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(long number)
        {
            if(number==0 || number == 1)
            {
                return false;
            }
            else
            {
                int counter = 0;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                        counter++;
                }
                if (counter > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
