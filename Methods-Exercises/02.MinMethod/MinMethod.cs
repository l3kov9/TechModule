namespace _02.MinMethod
{
    using System;
    public class MinMethod
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Min(GetMin(a,b),c));
        }

        private static int GetMin(int a,int b)
        {
            return Math.Min(a, b);
        }
    }
}
