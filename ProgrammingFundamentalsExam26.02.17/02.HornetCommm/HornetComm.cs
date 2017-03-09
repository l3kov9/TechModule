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
            var messages = new List<string>();
            var broadcast = new Dictionary<string, string>();

            while (!input.Equals("Hornet is Green"))
            {
                var list = input.Split().ToList();
                var firstElement = list[0];
                var secondElement = list[list.Count-1];

                var digitsInFirstElement = DigitCount(firstElement);

                var digitsInSecondElement = DigitCount(secondElement);
                var lettersInSecondElement = LetterCount(secondElement);
                var countSecondElement = digitsInSecondElement + lettersInSecondElement;

                if(firstElement.Length==digitsInFirstElement &&
                    (secondElement.Length==countSecondElement))
                {
                    var recipientCode = ReverseElement(firstElement);
                    var message = secondElement;
                    messages.Add($"{recipientCode} -> {message}");
                }
                if(digitsInFirstElement==0 &&
                    (secondElement.Length == countSecondElement))
                {
                    var frequency = ReverseLettersSize(secondElement);
                    var message = firstElement;

                    broadcast[frequency] = message;
                }
                    


                input = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcast.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var kvp in broadcast)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (var message in messages)
            {
                Console.WriteLine(message);
            }
        }

      

        private static int LetterCount(string secondElement)
        {
            var result = 0;
            for (int i = 0; i < secondElement.Length; i++)
            {
                if((secondElement[i]>='a' && secondElement[i]<='z')||(secondElement[i]>='A' && secondElement[i] <= 'Z'))
                {
                    result++;
                }
            }
            return result;
        }

        private static string ReverseLettersSize(string secondElement)
        {
            var result = string.Empty;

            for (int i = 0; i < secondElement.Length; i++)
            {
                if(secondElement[i]>='a' && secondElement[i] <= 'z')
                {
                    result += secondElement[i].ToString().ToUpper();
                }
                else if(secondElement[i] >= 'A' && secondElement[i] <= 'Z')
                {
                    result += secondElement[i].ToString().ToLower();
                }
                else
                {
                    result += secondElement[i].ToString();
                }
            }

            return result;
        }

        private static string ReverseElement(string firstElement)
        {
            var result = string.Empty;

            for (int i = firstElement.Length-1; i >= 0; i--)
            {
                result += firstElement[i].ToString();
            }

            return result;
        }

        private static int DigitCount(string element)
        {
            var count = 0;
            for (int i = 0; i < element.Length; i++)
            {
                if(element[i]>='0' && element[i] <= '9')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
