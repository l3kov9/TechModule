namespace _17.CypherRoulette
{
    using System;

    public class CypherRoulette
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string spin = "spin";
            string finalText = string.Empty;
            string lastText = string.Empty;
            int spinCount = 0;

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                if (text.Equals(spin))
                {
                    spinCount++;
                    text = Console.ReadLine();
                    if (text.Equals(spin))
                    {
                        finalText = string.Empty;
                        text = Console.ReadLine();
                        while (text.Equals(spin))
                        {
                            text = Console.ReadLine();
                        }

                        finalText += text;
                    }
                    else if (spinCount % 2 == 0)
                    {
                        finalText += text;
                    }
                    else
                    {
                        finalText = text + finalText;
                    }
                }
                else if (text.Equals(lastText))
                {
                    finalText = string.Empty;
                }
                else
                {
                    if (spinCount % 2 == 0)
                    {
                        finalText += text;
                    }
                    else
                    {
                        finalText = text + finalText;
                    }
                }

                lastText = text;
            }

            Console.WriteLine(finalText);
        }
    }
}
