namespace _01.MaxSequenceOfEqualElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var sequence = 1;
            int maxSequence = sequence;
            int mostSequenceElement = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    sequence++;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        mostSequenceElement = list[i];
                    }
                }
                else
                {
                    sequence = 1;
                }
            }

            var result = new List<int>();
            for (int i = 0; i < maxSequence; i++)
            {
                result.Add(mostSequenceElement);
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
