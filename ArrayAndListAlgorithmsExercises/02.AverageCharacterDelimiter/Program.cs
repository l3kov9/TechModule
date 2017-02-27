namespace _02.AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split();
            var listToString = string.Join("", list);
            var sum = 0;

            for (int i = 0; i < listToString.Length; i++)
            {
                sum += listToString[i];
            }

            int delimeterAsciCode = sum/listToString.Length;
            char delimeter = Convert.ToChar(delimeterAsciCode);

            Console.WriteLine(string.Join($"{delimeter.ToString().ToUpper()}", list));
        }
    }
}
