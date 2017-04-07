namespace _02.CountSubstringOccurrences
{
    using System;

    public class CountOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var counter = 0;

            while (text.IndexOf(pattern)!=-1)
            {
                text = text.Substring(text.IndexOf(pattern) + 1);
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
