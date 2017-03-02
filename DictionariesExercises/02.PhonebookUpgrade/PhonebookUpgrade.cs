namespace _02.PhonebookUpgrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Phonebook
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, string>();

            while (!command.Equals("END"))
            {
                var commandToList = command.Split().ToList();
                var name = commandToList.Count>1? commandToList[1]:string.Empty;

                if (commandToList[0].Equals("A"))
                {
                    var phoneNumber = commandToList[2];
                    phoneBook[name] = phoneNumber;
                }
                else if (commandToList[0].Equals("S"))
                {
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (commandToList[0].Equals("ListAll"))
                {
                    foreach (var kvp in phoneBook)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
