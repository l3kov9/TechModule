namespace _06.ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split();
            Console.WriteLine(string.Join(" ",array.Reverse()));
        }
    }
}
