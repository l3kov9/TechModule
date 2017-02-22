namespace _01.Last3ConsecutiveEqualStrings
{
    using System;
    public class Last3Strings
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split();
            int countRepeat = 1;
            string result = string.Empty;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].Equals(array[i - 1]))
                {
                    countRepeat++;
                }
                else
                {
                    countRepeat = 1;
                }

                if (countRepeat == 3)
                {
                    result = array[i];
                }
            }

                Console.WriteLine(result+ " " +result+" "+result);
        }
    }
}
