namespace _02.FishStatistics
{
    using System;
    using System.Text.RegularExpressions;

    public class FishStatistics
    {
        public static void Main()
        {
            var fish = Console.ReadLine();

            var pattern = "(>*)<(\\(+)(['\\-x])>";
            var regex = new Regex(pattern);
            var matches = regex.Matches(fish);
            var fishCounter = 1;

            if (matches.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }

            foreach (Match match in matches)
            {
                var tailLength = match.Groups[1].Value.Length;
                var tyleType = string.Empty;
                if (tailLength == 0)
                {
                    tyleType = "None";
                }
                else if (tailLength == 1)
                {
                    tyleType = "Short";
                }
                else if (tailLength > 5)
                {
                    tyleType = "Long";
                }
                else
                {
                    tyleType = "Medium";
                }

                var bodyLength = match.Groups[2].Value.Length;
                var bodyType = string.Empty;
                if (bodyLength > 10)
                {
                    bodyType = "Long";
                }
                else if (bodyLength > 5)
                {
                    bodyType = "Medium";
                }
                else
                {
                    bodyType = "Short";
                }

                var status = match.Groups[3].Value;
                if (status.Equals("'"))
                {
                    status = "Awake";
                }
                else if (status.Equals("-"))
                {
                    status = "Asleep";
                }
                else
                {
                    status = "Dead";
                }

                Console.WriteLine($"Fish {fishCounter}: {match.Value}");
                Console.WriteLine(tyleType.Equals("None")? $"Tail type: {tyleType}" : $"Tail type: {tyleType} ({tailLength*2} cm)");
                Console.WriteLine($"Body type: {bodyType} ({bodyLength*2} cm)");
                Console.WriteLine($"Status: {status}");

                fishCounter++;
            }
        }
    }
}
