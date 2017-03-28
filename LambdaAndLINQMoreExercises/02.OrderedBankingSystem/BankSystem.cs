namespace _02.OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class BankSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var bankSystem = new Dictionary<string, Dictionary<string, string>>();

            while (!input.Equals("end"))
            {
                var list = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                var bank = list[0];
                var account = list[1];
                var balance = list[2];

                AddToBankSystem(bankSystem, bank, account, balance);

                input = Console.ReadLine();
            }

            foreach (var kvp in bankSystem.OrderByDescending(x=>x.Value.Values.Max()).ThenByDescending(x=>x.Value.Values.Max()))
            {
                var bank = kvp.Key;
                foreach (var accountBalance in kvp.Value)
                {
                    Console.WriteLine($"{accountBalance.Key} -> {accountBalance.Value} ({bank})");
                }
            }
        }

        private static void AddToBankSystem(Dictionary<string, Dictionary<string, string>> bankSystem,
            string bank, string account, string balance)
        {
            if (!bankSystem.ContainsKey(bank))
            {
                bankSystem[bank] = new Dictionary<string, string>();
            }
            if (!bankSystem[bank].ContainsKey(account))
            {
                bankSystem[bank][account] = balance;
            }
            else
            {
                var result = decimal.Parse(bankSystem[bank][account]) + decimal.Parse(balance);
                bankSystem[bank][account] = $"{result.ToString():f2}";
            }
            
        }
    }
}
