namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            bool isFinished = false;

            while (!isFinished)
            {
                var length = list.Count;

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] == list[i + 1])
                    {
                        list[i] = list[i] * 2;
                        list.RemoveAt(i + 1);
                    }
                }

                if (length == list.Count)
                {
                    isFinished = true;
                }
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
