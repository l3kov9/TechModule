namespace _03.ExactProductOfRealNumbers
{
    using System;
    public class ExactProductOfRealNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum=1;
            for (int i = 0; i < n; i++)
            {
                sum *= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
