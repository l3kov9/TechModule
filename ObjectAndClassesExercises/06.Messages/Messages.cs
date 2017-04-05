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
            var userDictionary = new Dictionary<string, User>();
            var receiverDictionary = new Dictionary<string, List<Message>>();

            while (!input.Equals("exit"))
            {
                var list = input.Split().ToList();
                if (list[0].Equals("register"))
                {
                    var user = new User
                    {
                        Username = list[1],
                        ReceivedMessages = new List<Message>()
                    };

                    userDictionary[user.Username] = user;
                }
                else
                {
                    var senderUsername = list[0];
                    var recipientUsername = list[2];
                    var content = list[3];

                    if(userDictionary.ContainsKey(senderUsername) && userDictionary.ContainsKey(recipientUsername))
                    {
                        var message = new Message
                        {
                            Content = content,
                            Sender = userDictionary[senderUsername]
                        };

                        if (!receiverDictionary.ContainsKey(recipientUsername))
                        {
                            receiverDictionary[recipientUsername] = new List<Message>();
                        }

                        receiverDictionary[recipientUsername].Add(message);

                        userDictionary[senderUsername].ReceivedMessages.Add(message);
                    }
                }

                input = Console.ReadLine();
            }

            var userNameList = Console.ReadLine().Split().ToList();
            var firstUser = userNameList[0];
            var secondUser = userNameList[1];

            foreach (var kvp in receiverDictionary)
            {
                var receiver = kvp.Key;
                var messageList = kvp.Value;

                if(receiver.Equals(firstUser) || receiver.Equals(secondUser))
                {
                    foreach (var message in messageList)
                    {
                        Console.WriteLine("{0}: {1}", receiver.Equals(firstUser) ? firstUser : secondUser, message.Content);
                    }
                }
            }
        }

        public class User
        {
            public string Username { get; set; }
            public List<Message> ReceivedMessages { get; set; }
        }

        public class Message
        {
            public string Content { get; set; }
            public User Sender { get; set; }
        }
    }
}
