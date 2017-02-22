namespace _09.Index_of_Letters
{
    using System;
    using System.Linq;

    public class IndexOfLetters
    {
        public static void Main()
        {
            string[] alphabet ="a b c d e f g h i j k l m n o p q r s t u v w x y z".Split();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j].Equals(text[i].ToString()))
                    {
                        Console.WriteLine($"{text[i]} -> {j}");
                    }
                }
            }
        }
    }
}
