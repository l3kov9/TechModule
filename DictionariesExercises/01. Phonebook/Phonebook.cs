namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Phonebook
    {
        public static void Main()
        {
            var command = Console.ReadLine();
            var phoneBook = new Dictionary<string, string>();

            while (!command.Equals("END"))
            {
                var commandToList = command.Split().ToList();
                var name = commandToList[1];

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

                command = Console.ReadLine();
            }
        }
    }
}
