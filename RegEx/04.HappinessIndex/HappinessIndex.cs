using System;
using System.Text.RegularExpressions;

namespace _04.HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            var pattern = @"((?:[:;\(\*c\[])(?:[\)D\*\]}:;]))|((?:[:D;\]\)])(?:[\(:\[{c;]))";
            var regex = new Regex(pattern);

            var matches = regex.Matches(Console.ReadLine());
            var happyEmoticonsCount = 0;
            var sadEmoticonsCount = 0;

            foreach (Match match in matches)
            {
                if (match.Groups[1].Success)
                {
                    happyEmoticonsCount++;
                }
                else
                {
                    sadEmoticonsCount++;
                }
            }

            var happinessIndex = $"{(decimal)happyEmoticonsCount / sadEmoticonsCount:f2}";
            var emoticonScore = string.Empty;
            if (decimal.Parse(happinessIndex) >= 2)
            {
                emoticonScore = ":D";
            }
            else if (decimal.Parse(happinessIndex) > 1)
            {
                emoticonScore = ":)";
            }
            else if (decimal.Parse(happinessIndex) == 1)
            {
                emoticonScore = ":|";
            }
            else
            {
                emoticonScore = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex} {emoticonScore}");
            Console.WriteLine($"[Happy count: {happyEmoticonsCount}, Sad count: {sadEmoticonsCount}]");
        }
    }
}
