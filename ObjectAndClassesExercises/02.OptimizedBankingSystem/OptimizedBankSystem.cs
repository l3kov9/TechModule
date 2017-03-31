using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OptimizedBankingSystem
{
    public class OptimizedBankSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var listOfBankAccounts = new List<BankAccount>();

            while (!input.Equals("end"))
            {
                var list = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var bankAccount = new BankAccount
                {
                    Name = list[1],
                    Bank = list[0],
                    Balance = decimal.Parse(list[2])
                };
                listOfBankAccounts.Add(bankAccount);

                input = Console.ReadLine();
            }

            foreach (var account in listOfBankAccounts.OrderByDescending(x=>x.Balance).ThenBy(x=>x.Bank.Length))
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }

        public class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }
        }
    }
}
