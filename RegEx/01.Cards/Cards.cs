namespace _01.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Cards
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = "((?:1?[0-9])|[JQKA])([SHDC])";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            var cardList = new List<string>();

            foreach (Match match in matches)
            {
                var result = 0;
                var power = match.Groups[1].Value;

                if(int.TryParse(power,out result) && (int.Parse(power)<2 || int.Parse(power)>10))
                {
                    continue ;
                }

                cardList.Add(match.Value);
            }
            
            Console.WriteLine(string.Join(", ",cardList));
        }
    }
}
