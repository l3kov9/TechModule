namespace _01.Register_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    public class RegisterUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var register = new Dictionary<string, DateTime>();

            while (!input.Equals("end"))
            {
                var list = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var username = list[0];
                var date = DateTime.ParseExact(list[list.Count - 1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                AddToDictionary(register, username, date);

                input = Console.ReadLine();
            }

            var result = register.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value);
            foreach (var user in result)
            {
                Console.WriteLine(user.Key);
            }
        }

        private static void AddToDictionary(Dictionary<string, DateTime> register, string username, DateTime date)
        {
            register[username] = date;
        }
    }
}
