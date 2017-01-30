namespace _03.PrintTriangle
{
    using System;
    public class PrintTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangleFromNums(n);
        }

        private static void PrintTriangleFromNums(int n)
        {
            PrintFirstHalf(n);
            PrintSecondHalf(n-1);
        }

        private static void PrintSecondHalf(int n)
        {
            for (int i = n; i >=1; i--)
            {
                PrintLine(i);
            }
        }

        private static void PrintFirstHalf(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
        }

        private static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}
