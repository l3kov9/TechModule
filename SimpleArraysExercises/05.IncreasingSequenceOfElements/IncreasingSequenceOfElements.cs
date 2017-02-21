namespace _05.IncreasingSequence_of_Elements
{
    using System;
    using System.Linq;

    public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isIncreasingArray = false;
            int previousNum = array[0]; 

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > previousNum)
                {
                    isIncreasingArray = true;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
