namespace _04.NthDigit
{
    using System;
    using System.Linq;

    public class NthDigit
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            string indexNumber = FindNthIndex(number, index);
            Console.WriteLine(indexNumber);
        }

        private static string FindNthIndex(int number, int index)
        {
            int count = 1;
            while (count!=index)
            {
                number /= 10;
                count++;
            }
            return (number % 10).ToString();
        }
    }
}
