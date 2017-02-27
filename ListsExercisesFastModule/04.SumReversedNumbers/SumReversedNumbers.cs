namespace _04.SumReversedNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SumReversedNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                string intToText = list[i].ToString();
                string reversedNum=string.Empty;
                for (int j = intToText.Length-1; j >= 0; j--)
                {
                    reversedNum += intToText[j];
                }

                list[i] = int.Parse(reversedNum);
            }

            Console.WriteLine(list.Sum());
        }
    }
}
