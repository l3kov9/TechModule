namespace _04.TrippleSum
{
    using System;
    using System.Linq;

    public class TrippleSum
    {
        public static void Main()
        {
            bool containsTripleSum = false;

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array.Contains(array[i] + array[j]))
                    {
                        Console.WriteLine($"{array[i]} + {array[j]} == {array[i] + array[j]}");
                        containsTripleSum = true;

                    }
                }
            }

            if (!containsTripleSum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
