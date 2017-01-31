namespace _08.StringEncryption
{
    using System;
    public class StringEncryption
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string encryptedMessage = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = Convert.ToChar(Console.ReadLine());
                int asci = letter;
                int firstDigit = 0;
                foreach (var digit in asci.ToString())
                {
                    firstDigit = int.Parse(digit.ToString());
                    break;
                }
                int lastDigit = asci % 10;
                char firstLetter = Convert.ToChar(asci + lastDigit);
                char lastLetter = Convert.ToChar(asci - firstDigit);
                encryptedMessage += firstLetter.ToString() + firstDigit.ToString() + lastDigit.ToString() + lastLetter.ToString();
            }
            Console.WriteLine(encryptedMessage);
        }
    }
}
