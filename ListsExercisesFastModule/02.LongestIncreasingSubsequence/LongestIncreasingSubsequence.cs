namespace _02.LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultList = new List<int>();
            var longestIncrease = new List<int>();
            if (list.Count == 1)
            {
                Console.WriteLine(list[0]);
                return;
            }

            for (int i = 0; i < list.Count-1; i++)
            {
                var currentElement = list[i];
                resultList.Add(currentElement);
                var previousElement = currentElement;

                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] > currentElement)
                    {
                        resultList.Add(list[j]);
                        previousElement = currentElement;
                        currentElement = list[j];
                    }

                    if (list[j] < resultList[resultList.Count - 1] && list[j] > previousElement)
                    {
                        resultList.RemoveAt(resultList.Count - 1);
                        resultList.Add(list[j]);
                        currentElement = list[j];
                    }
                }

                if (resultList.Count > longestIncrease.Count)
                {
                    longestIncrease.Clear();
                    foreach (var num in resultList)
                    {
                        longestIncrease.Add(num);
                    }
                }
                resultList.Clear();
            }

            Console.WriteLine(string.Join(" ",longestIncrease));
        }
    }
}
