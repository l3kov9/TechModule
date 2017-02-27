namespace _05.BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class BombNumbers
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var specialList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombNumber = specialList[0];
            var bombPower = specialList[1];

            while (list.Contains(bombNumber))
            {
                var bombIndex = list.IndexOf(bombNumber);
                ExplodeRightSize(list, bombPower, bombNumber, bombIndex);
                ExplodeLeftSize(list, bombPower, bombNumber, bombIndex);
            }

            Console.WriteLine(list.Sum());
        }

        private static void ExplodeRightSize(List<int> list, int bombPower, int bombNumber, int bombIndex)
        {
            var count = bombPower;
            if (list.Count < count + bombIndex)
            {
                count = list.Count - bombIndex;
            }
            list.RemoveRange(bombIndex, count);
        }

        private static void ExplodeLeftSize(List<int> list, int bombPower, int bombNumber, int bombIndex)
        {
            var count = bombIndex - bombPower;
            if (0 > bombIndex - bombPower)
            {
                count = 0;
            }
            list.RemoveRange(count, bombIndex+1);
        }
    }
}
