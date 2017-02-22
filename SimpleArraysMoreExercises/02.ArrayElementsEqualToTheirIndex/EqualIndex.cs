namespace _02.ArrayElementsEqualToTheirIndex
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualIndex
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> equalIndex = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                {
                    equalIndex.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ",equalIndex));
        }
    }
}
