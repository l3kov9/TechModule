namespace _07.CountOfCapitalLettersInArray
{
    using System;
    public class CountOfCapitalLetters
    {
        public static void Main()
        {
            string[] array = Console.ReadLine().Split();
            int countCapitalLetters = 0;

            foreach (var word in array)
            {
                if (word.Length == 1)
                {
                    if(Convert.ToChar(word)>=65 && Convert.ToChar(word) <= 90)
                    {
                        countCapitalLetters++;
                    }
                }
            }

            Console.WriteLine(countCapitalLetters);
        }
    }
}
