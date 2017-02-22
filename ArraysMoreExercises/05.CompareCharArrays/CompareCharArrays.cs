namespace _05.CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            string[] firstCharArray = Console.ReadLine().Split();
            string[] secondCharArray = Console.ReadLine().Split();

            string[] finalArray = { string.Join("", firstCharArray), string.Join("", secondCharArray) };
            finalArray=finalArray.OrderBy(x => x).ToArray();
            foreach (var item in finalArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
