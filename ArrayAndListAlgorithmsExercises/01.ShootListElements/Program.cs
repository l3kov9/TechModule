namespace _01.ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var list = new List<int>();
            var lastRemovedElement = 0;

            while (command!="stop")
            {
                if (command != "bang")
                {
                    list.Insert(0, int.Parse(command));
                }
                else
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemovedElement}");
                        return;
                    }

                    double averageSum = list.Average();

                    if (list.Count == 1)
                    {
                        lastRemovedElement = list[0];
                        list.Remove(lastRemovedElement);
                        Console.WriteLine($"shot {lastRemovedElement}");
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] < averageSum)
                            {
                                lastRemovedElement = list[i];
                                list.Remove(lastRemovedElement);
                                Console.WriteLine($"shot {lastRemovedElement}");
                                for (int j = 0; j < list.Count; j++)
                                {
                                    list[j]--;
                                }
                                break;
                            }
                        }
                    }

                }

                command = Console.ReadLine();
            }

            if (list.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ",list)}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastRemovedElement}");
            }
        }
    }
}
