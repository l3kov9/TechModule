namespace _16.TrickyStrings
{
    using System;
    public class TrickyString
    {
        public static void Main()
        {
            string delimeter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string finalText = "";
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                if (i == n - 1)
                    finalText += text;
                else
                    finalText += text + delimeter;
            }
            Console.WriteLine(finalText);
        }
    }
}
