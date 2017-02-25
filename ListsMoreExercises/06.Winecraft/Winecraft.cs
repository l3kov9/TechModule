namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Winecraft
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            var listLength = list.Count;

            while (listLength == list.Count)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (list[k] > 0)
                            list[k] += 1;
                    }

                    for (int j = 1; j < list.Count-1; j++)
                    {
                        if(list[j]>list[j-1] && list[j] > list[j + 1])
                        {
                            if (list[j - 1] > 0 && list[j+1]>0)
                            {
                                list[j - 1] -= 2;
                                list[j + 1] -= 2;
                                list[j] += 1;
                            }
                            else if(list[j - 1] > 0 && list[j + 1] == 0)
                            {
                                list[j - 1] -= 2;
                            }
                            else if(list[j - 1] == 0 && list[j + 1] > 0)
                            {
                                list[j + 1] -= 2;
                            }
                        }
                    }
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] < n)
                    {
                        list.Remove(list[i]);
                        i = 0;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
