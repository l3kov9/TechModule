﻿namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FixingEmails
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var emailBook = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                var email = Console.ReadLine();

                var lastTwoEmailLetters = email.Substring(email.Length - 2);

                if (!lastTwoEmailLetters.Equals("us") && !lastTwoEmailLetters.Equals("uk"))
                {
                    emailBook[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var kvp in emailBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
