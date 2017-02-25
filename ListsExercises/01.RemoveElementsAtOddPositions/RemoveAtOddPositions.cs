namespace _01.RemoveElementsAtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RemoveAtOddPositions
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToList();
            var result = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 == 1)
                {
                    result.Add(words[i]);
                }
            }

            Console.WriteLine(string.Join("",result));
        }
    }
}
