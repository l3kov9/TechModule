namespace _03.StringRepeater
{
    using System;
    public class StringRepeater
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int repeatTextCount = int.Parse(Console.ReadLine());
            string repeatedText = RepeatString(text, repeatTextCount);
            Console.WriteLine(repeatedText);
        }

        private static string RepeatString(string text, int repeatTextCount)
        {
            string repeatedText = string.Empty;
            for (int i = 0; i < repeatTextCount; i++)
            {
                repeatedText += text;
            }
            return repeatedText;
        }
    }
}
