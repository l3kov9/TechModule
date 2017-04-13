namespace _05.WinningTicketWithRegEx
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WinningTicketWithRegEx
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var pattern = @"([@#$^])\1{5,}";

            foreach (var ticket in tickets)
            {
                var firstPart = ticket.Substring(0, ticket.Length / 2);
                var secondPart = ticket.Substring(ticket.Length / 2);

                var regex = new Regex(pattern);

                var firstPartMatch = regex.Match(firstPart);
                var secondPartMatch = regex.Match(secondPart);

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                if (firstPartMatch.Success && secondPartMatch.Success)
                {
                    var winningCounter = Math.Min(firstPartMatch.Value.Length, secondPartMatch.Value.Length);
                    var winningSymbol = firstPartMatch.Value[0];
                    if (winningCounter < 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {winningCounter}{winningSymbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {winningCounter}{winningSymbol} Jackpot!");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }

            }
        }
    }
}
