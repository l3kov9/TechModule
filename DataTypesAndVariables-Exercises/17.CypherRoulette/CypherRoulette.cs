namespace _17.CypherRoulette
{
    using System;
    class CypherRoulette
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string spin = "spin";
            string finalText = "";
            string lastText = "";
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
                        finalText = "";
                        text = Console.ReadLine();
                        while (text.Equals(spin))
                        {
                            text = Console.ReadLine();
                        }
                            finalText += text;
                    }
                    else if (spinCount % 2 == 0)
                        finalText += text;
                    else
                        finalText = text + finalText;
                }
                else if (text.Equals(lastText))
                {
                    finalText = "";
                }
                else
                {
                    if(spinCount % 2 == 0)
                        finalText += text;
                    else
                        finalText = text + finalText;
                }
                lastText = text;
            }
            Console.WriteLine(finalText);
        }
    }
}
