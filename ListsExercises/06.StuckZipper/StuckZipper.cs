namespace _06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StuckZipper
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int minNumber = Math.Abs(Math.Min(firstList.Min(), secondList.Min()));
            int minDigitAmount = minNumber.ToString().Length;

            for (int i = 0; i < firstList.Count; i++)
            {
                string numToStr = Math.Abs(firstList[i]).ToString();
                if (numToStr.Length > minDigitAmount)
                {
                    firstList.Remove(firstList[i]);
                    i--;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                string numToStr = Math.Abs(secondList[i]).ToString();
                if (numToStr.Length > minDigitAmount)
                {
                    secondList.Remove(secondList[i]);
                    i--;
                }
            }

            var resultList = new List<int>();

            for (int i = 0; i < Math.Max(firstList.Count,secondList.Count); i++)
            {
                if (i < secondList.Count)
                {
                    resultList.Add(secondList[i]);
                }
                if (i < firstList.Count)
                {
                    resultList.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
