namespace _03.IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class IncreasingCrisis
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            result.AddRange(inputList);
            CheckForIncreasingElements(result);

            for (int i = 0; i < n - 1; i++)
            {
                var isAdded = false;
                inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
                var firstAddingElement = inputList[0];

                for (int j = result.Count - 1; j >= 0; j--)
                {
                    if (result[j] <= firstAddingElement)
                    {
                        if (j == result.Count - 1)
                        {
                            result.AddRange(inputList);
                        }
                        else
                        {
                            result.InsertRange(j + 1, inputList);
                        }
                        CheckForIncreasingElements(result);
                        isAdded = true;
                        break;
                    }
                }

                if (!isAdded)
                {
                    result.InsertRange(0, inputList);
                    CheckForIncreasingElements(result);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static void CheckForIncreasingElements(List<int> result)
        {
            for (int k = 1; k < result.Count; k++)
            {
                if (result[k-1]>result[k])
                {
                    result.RemoveRange(k, result.Count - k);
                }
            }
        }
    }
}
