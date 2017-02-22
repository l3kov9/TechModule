namespace _08.CondenseArrayToNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = array.Length;
            List<int> resultArray = new List<int>();

            while (length>1)
            {
                for (int i = 0; i < length-1; i++)
                {
                    array[i] = array[i] + array[i + 1];
                }
                length--;
            }

            Console.WriteLine(array[0]);
        }
    }
}
