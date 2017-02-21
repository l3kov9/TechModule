namespace _08.ArraySymmetry
{
    using System;
    using System.Linq;

    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split();
            string[] reversedArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[i];
            }

            reversedArray = reversedArray.Reverse().ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != reversedArray[i])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
