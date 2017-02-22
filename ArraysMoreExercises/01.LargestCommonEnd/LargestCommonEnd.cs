namespace _01.LargestCommonEnd
{
    using System;
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            int countCommonWordsBeginning = 0;

            for (int i = 0; i < Math.Min(firstArray.Length,secondArray.Length); i++)
            {
                if (firstArray[i].Equals(secondArray[i]))
                {
                    countCommonWordsBeginning++;
                }
                else
                {
                    break;
                }
            }

            int countCommonWordsEnding = 0;

            for (int i = 0; i < Math.Min(firstArray.Length,secondArray.Length); i++)
            {
                if (firstArray[firstArray.Length-1-i].Equals(secondArray[secondArray.Length-1-i]))
                {
                    countCommonWordsBeginning++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(countCommonWordsBeginning,countCommonWordsEnding));
        }
    }
}
