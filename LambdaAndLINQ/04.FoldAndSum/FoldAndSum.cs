namespace _04.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FoldAndSum
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var k = arr.Length / 4;
            var firstPartLeftSide = arr.Take(k).Reverse().ToArray();
            var firstPartSecondSide = arr.Reverse().Take(k).ToArray();
            var firstRow = firstPartLeftSide.Concat(firstPartSecondSide).ToArray();
            var secondRow = arr.Skip(k).Take(k * 2).ToArray();

            for (int i = 0; i < secondRow.Length; i++)
            {
                Console.Write(firstRow[i]+secondRow[i]+" ");
            }
        }
    }
}
