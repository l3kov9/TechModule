namespace _06.IncrementVariable
{
    using System;
    public class IncrementVariable
    {
        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            int countByte = byte.MaxValue + 1;
            int result = x % countByte;
            Console.WriteLine(result);
            if (result != x)
                Console.WriteLine("Overflowed {0} times",(int)x/countByte);
        }
    }
}
