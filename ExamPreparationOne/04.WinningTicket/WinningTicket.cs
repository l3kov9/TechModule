namespace _04.WinningTicket
{
    using System;
    using System.Linq;

    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var firstHalf = ticket.Substring(0, ticket.Length/2);
                var secondHalf = ticket.Substring(ticket.Length/2);

                var firstSymbolInFirstHalf = CheckForJackpot('@', firstHalf);
                var firstSymbolInSecondHalf = CheckForJackpot('@', secondHalf);

                if(firstSymbolInFirstHalf>=6 && firstSymbolInSecondHalf >= 6 && (firstSymbolInSecondHalf<10 || firstSymbolInFirstHalf<10))
                {
                    PrintWinningTicket('@', Math.Min(firstSymbolInSecondHalf, firstSymbolInFirstHalf), ticket);
                    continue;
                }
                if (firstSymbolInFirstHalf == 10 && firstSymbolInSecondHalf == 10)
                {
                    Printjackpot('@', ticket);
                    continue;
                }

                var forthSymbolInFirstHalf = CheckForJackpot('^', firstHalf);
                var forthSymbolInSecondHalf = CheckForJackpot('^', secondHalf);

                if (forthSymbolInFirstHalf >= 6 && forthSymbolInSecondHalf >= 6 && (forthSymbolInFirstHalf < 10 || forthSymbolInSecondHalf<10))
                {
                    PrintWinningTicket('^', Math.Min(forthSymbolInFirstHalf,forthSymbolInSecondHalf), ticket);
                    continue;
                }
                if (forthSymbolInFirstHalf == 10 && forthSymbolInSecondHalf == 10)
                {
                    Printjackpot('^', ticket);
                    continue;
                }

                var secondSymbolInFirstHalf = CheckForJackpot('#', firstHalf);
                var secondSymbolInSecondHalf = CheckForJackpot('#', secondHalf);

                if (secondSymbolInFirstHalf >= 6 && secondSymbolInSecondHalf >= 6 && (secondSymbolInFirstHalf < 10 || secondSymbolInSecondHalf<10))
                {
                    PrintWinningTicket('#', Math.Min(secondSymbolInFirstHalf, secondSymbolInSecondHalf), ticket);
                    continue;
                }
                if (secondSymbolInSecondHalf == 10 && secondSymbolInFirstHalf == 10)
                {
                    Printjackpot('#', ticket);
                    continue;
                }

                var thirdSymbolInFirstHalf = CheckForJackpot('$', firstHalf);
                var thirdSymbolInSecondHalf = CheckForJackpot('$', secondHalf);

                if (thirdSymbolInFirstHalf >= 6 && thirdSymbolInSecondHalf >= 6 && (thirdSymbolInFirstHalf < 10 || thirdSymbolInSecondHalf<10))
                {
                    PrintWinningTicket('$', Math.Min(thirdSymbolInFirstHalf, thirdSymbolInSecondHalf), ticket);
                    continue;
                }
                if (thirdSymbolInFirstHalf == 10 && thirdSymbolInSecondHalf == 10)
                {
                    Printjackpot('$', ticket);
                    continue;
                }


                Console.WriteLine($"ticket \"{ticket}\" - no match");
            }
        }

        private static void Printjackpot(char symbol, string ticket)
        {
            Console.WriteLine($"ticket \"{ticket}\" - 10{symbol} Jackpot!");
        }

        private static void PrintWinningTicket(char symbol, int matchLength, string ticket)
        {
            Console.WriteLine($"ticket \"{ticket}\" - {matchLength}{symbol}");
        }

        private static int CheckForJackpot(char symbol, string halfTicket)
        {
            var counter = 0;
            var maxCount = 0;
            foreach (var letter in halfTicket)
            {
                if (letter.Equals(symbol))
                {
                    counter++;
                    maxCount = counter;
                }
                else
                {
                    counter = 0;
                }
            }
            return maxCount;
        }
    }
}
