namespace _02.SignOfIntegerNumber
{
    using System;
    public class SignOfIntegerNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintSignOfInteger(n);
        }

        private static void PrintSignOfInteger(int n)
        {
            if(n>0)
                Console.WriteLine($"The number {n} is positive.");
            else if(n<0)
                Console.WriteLine($"The number {n} is negative.");
            else
                Console.WriteLine($"The number {n} is zero.");
        }
    }
}
