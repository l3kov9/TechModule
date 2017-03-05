namespace _05.UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class UserLogins
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var userLogin = new Dictionary<string, string>();

            while (!input.Equals("login"))
            {
                var list = input.Split().ToList();
                var name = list[0];
                var password = list[2];

                userLogin[name] = password;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var counter = 0;
            while (!input.Equals("end"))
            {
                var list = input.Split().ToList();
                var name = list[0];
                var password = list[2];

                if (userLogin.ContainsKey(name))
                {
                    if (userLogin[name] == password)
                    {
                        Console.WriteLine($"{name}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{name}: login failed");
                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine($"{name}: login failed");
                    counter++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}
