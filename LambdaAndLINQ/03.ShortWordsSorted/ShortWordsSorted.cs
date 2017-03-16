namespace _03.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            var inputList = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = inputList.Where(x => x.Length < 5).OrderBy(x => x).Distinct();

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
