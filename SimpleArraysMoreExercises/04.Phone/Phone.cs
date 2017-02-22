namespace _04.Phone
{
    using System;
    using System.Linq;
    public class Phone
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split();
            string[] names = Console.ReadLine().Split();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "done")
            {
                if (command[0].Equals("message"))
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (command[1].Equals(names[i]))
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                            int DiffDigits = DifferenceBetweenDigits(phoneNumbers[i]);
                            if (DiffDigits % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                        else if (command[1].Equals(phoneNumbers[i]))
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                            int DiffDigits = DifferenceBetweenDigits(phoneNumbers[i]);
                            if (DiffDigits % 2 != 0)
                            {
                                Console.WriteLine("busy");
                            }
                            else
                            {
                                Console.WriteLine("meet me there");
                            }
                        }
                    }
                }

                if (command[0].Equals("call"))
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (command[1].Equals(names[i]))
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                            int sumOfDigits = SumDigits(phoneNumbers[i]);
                            if (sumOfDigits % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = 0;
                                int seconds = sumOfDigits;
                                if (sumOfDigits > 59)
                                {
                                    minutes = 1;
                                    seconds = sumOfDigits % 60;
                                }
                                Console.WriteLine("call ended. duration: 0{0}:{1}", minutes, seconds);
                            }
                        }
                        else if (command[1].Equals(phoneNumbers[i]))
                        {
                            Console.WriteLine($"calling {names[i]}...");
                            int sumOfDigits = SumDigits(phoneNumbers[i]);
                            if (sumOfDigits % 2 != 0)
                            {
                                Console.WriteLine("no answer");
                            }
                            else
                            {
                                int minutes = 0;
                                int seconds = sumOfDigits;
                                if (sumOfDigits > 59)
                                {
                                    minutes = 1;
                                    seconds = sumOfDigits % 60;
                                }
                                Console.WriteLine("call ended. duration: 0{0}:{1}", minutes, seconds);
                            }
                        }
                    }
                }

                for (int i = 0; i < names.Length; i++)
                {
                    if (command[0].Equals(names[i]))
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
                command = Console.ReadLine().Split();
            }
        }

        private static int DifferenceBetweenDigits(string phoneNumber)
        {
            int diffOfDigits = 0;
            foreach (var symbol in phoneNumber)
            {
                if (symbol >= '1' && symbol <= '9')
                {
                    diffOfDigits -= int.Parse(symbol.ToString());
                }
            }
            return diffOfDigits;
        }

        private static int SumDigits(string phoneNumber)
        {
            int sumOfDigits = 0;
            foreach (var symbol in phoneNumber)
            {
                if (symbol >= '1' && symbol <= '9')
                {
                    sumOfDigits += int.Parse(symbol.ToString());
                }
            }
            return sumOfDigits;
        }
    }
}
