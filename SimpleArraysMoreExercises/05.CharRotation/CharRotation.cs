namespace _05.CharRotation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharRotation
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<char> result = new List<char>();

            for (int i = 0; i < array.Length; i++)
            {
                int asciNum = 0;
                if (array[i] % 2 == 0)
                {
                    asciNum = text[i] - array[i];
                }
                else
                {
                    asciNum = text[i] + array[i];
                }
                result.Add(Convert.ToChar(asciNum));
            }

            Console.WriteLine(string.Join("",result));
        }
    }
}
