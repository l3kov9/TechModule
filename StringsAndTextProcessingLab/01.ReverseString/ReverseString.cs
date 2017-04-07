namespace _01.ReverseString
{
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            var reversedText = ReverseText(Console.ReadLine());

            Console.WriteLine(reversedText);
        }

        private static string ReverseText(string text)
        {
            var sb = new StringBuilder();

            for (int i = text.Length-1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }
    }
}
