namespace _04.ArrayHistogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ArrayHistogram
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().ToList();
            var sizeList = list.Count;

            while (list.Count!=0)
            {
                var elementToRemove = string.Empty;
                var maxCounter = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    var counter = 0;
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[i] == list[j])
                        {
                            counter++;
                            if (counter > maxCounter)
                            {
                                maxCounter = counter;
                                elementToRemove = list[i];
                            }
                        }
                    }
                }
                double percentage = (double)maxCounter / sizeList * 100.0;
                Console.WriteLine($"{elementToRemove} -> {maxCounter} times ({percentage:f2}%)");

                while (list.Contains(elementToRemove))
                {
                    list.Remove(elementToRemove);
                }
            }
        }
    }
}
