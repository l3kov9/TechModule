namespace _14.ASCIIString
{
    using System;
    public class ASCIISTRING
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = "";
            for (int i = 0; i < n; i++)
            {
                int asciiNumber = int.Parse(Console.ReadLine());
                string asciiToCHar= Convert.ToChar(asciiNumber).ToString();
                text += asciiToCHar;
            }
            Console.WriteLine(text);
        }
    }
}
