namespace _02.HornetCommm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HornetComm
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var broadcast = new Dictionary<string, string>();
            var messages = new List<string>();

            while (!input.Equals("Hornet is Green"))
            {
                var list = input.Split().ToList();
                var firstElement = list[0];
                var secondElement = list[list.Count - 1];
                var iSFoundDigit = true;
                for (int i = 0; i < firstElement.Length; i++)
                {
                    if(firstElement[i]<'0' || firstElement[i] > '9')
                    {
                        iSFoundDigit = false;
                    }
                }

                if (iSFoundDigit)
                {
                    var text = string.Empty;
                    for (int i = firstElement.Length-1; i >= 0; i--)
                    {
                        text += firstElement[i];
                    }
                    string result = $"{text} -> {secondElement}";
                    messages.Add(result);
                }
                
                iSFoundDigit = false;
                for (int i = 0; i < firstElement.Length; i++)
                {
                    if(firstElement[i]>='0' && firstElement[i] <= '9')
                    {
                        iSFoundDigit = true;
                    }
                }
                if (!iSFoundDigit)
                {
                    broadcast[secondElement.ToUpper()] = firstElement;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            foreach (var kvp in broadcast)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine("Messages:");
            foreach (var kvp in messages)
            {
                Console.WriteLine(kvp);
            }
            
        }
    }
}
