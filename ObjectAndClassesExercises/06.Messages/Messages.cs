namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Messages
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (!input.Equals("exit"))
            {
                var list = input.Split().ToList();
                if (list[0].Equals("register"))
                {
                    var user = new User
                    {
                        Username = list[1],
                        ReceivedMessages = new List<string>()
                    };
                }

                input = Console.ReadLine();
            }
        }

        public class User
        {
            public string Username { get; set; }
            public List<string> ReceivedMessages { get; set; }
        }

        public class Message
        {
            public string Content { get; set; }
            public User Sender { get; set; }
        }
    }
}
