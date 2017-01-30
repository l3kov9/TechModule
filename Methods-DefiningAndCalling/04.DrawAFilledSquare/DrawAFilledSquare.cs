namespace _04.DrawAFilledSquare
{
    using System;
    public class DrawAFilledSquare
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);
        }

        private static void PrintFilledSquare(int n)
        {
            PrintHeader(n);
            PrintBody(n - 2);
            PrintHeader(n);
        }

        private static void PrintBody(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write('-');
                PrintInsideTriangle(n + 1);
                Console.WriteLine('-');
            }
        }

        private static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-',n*2));
        }

        private static void PrintInsideTriangle(int insideBodyTriangle)
        {
            for (int i = 0; i < insideBodyTriangle; i++)
            {
                Console.Write(@"\/");
            }
        }
    }
}
