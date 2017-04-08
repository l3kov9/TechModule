using System;
using System.Collections.Generic;

namespace _04.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var delimeter = Console.ReadLine();
            var result = new List<string>();

            while (input.IndexOf(delimeter) != -1)
            {
                var element = input.Substring(0, input.IndexOf(delimeter));
                result.Add(element);
                input = input.Remove(0, element.Length+delimeter.Length);
            }
            result.Add(input);
            Console.WriteLine("[" + string.Join(", ", result) + "]");
        }
    }
}
