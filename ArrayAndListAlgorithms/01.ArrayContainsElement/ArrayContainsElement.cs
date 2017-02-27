using System;
using System.Linq;

namespace _01.ArrayContainsElement
{
    public class ArrayContainsElement
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var element = int.Parse(Console.ReadLine());
            var exist = false;

            foreach (var num in list)
            {
                if (num == element)
                {
                    exist = true;
                    Console.WriteLine("yes");
                    break;
                }
            }

            if (!exist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
