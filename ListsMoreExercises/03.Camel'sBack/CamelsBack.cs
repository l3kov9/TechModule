namespace _03.Camel_sBack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CamelsBack
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camelSize = int.Parse(Console.ReadLine());

            var rounds = 0;

            if (list.Count == camelSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ", list)}");
            }
            else
            {
                while (list.Count != camelSize)
                {
                    rounds++;
                    list.RemoveAt(0);
                    list.RemoveAt(list.Count - 1);
                }

                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ",list)}");
            }
        }
    }
}
