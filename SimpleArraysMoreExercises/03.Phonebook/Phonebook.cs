namespace _03.Phonebook
{
    using System;
    using System.Linq;
    public class Phonebook
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string command = Console.ReadLine();

            while (command!="done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (command.Equals(names[i]))
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
                command = Console.ReadLine();
            }

        }
    }
}
