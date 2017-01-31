namespace _7.PrimesInGivenRange
{
    using System;
    using System.Collections.Generic;

    public class PrimesInGivenRange
    {
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            List<int> primesNumbersInRange = FindPrimesInRange(startNumber, endNumber);
            Console.WriteLine(String.Join(", ",primesNumbersInRange));
        }

        private static List<int> FindPrimesInRange(int startNumber, int endNumber)
        {
            List<int> returnList=new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter=0;
                for (int k = 2; k <= Math.Sqrt(i); k++)
                {
                    if (i % k == 0)
                    {
                        counter++;
                    }

                }
                if (counter == 0)
                {
                    returnList.Add(i);
                }
            }
            return returnList;
        }
    }
}
