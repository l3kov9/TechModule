namespace _05.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DecodeFrequencies
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().ToList();
            var result = new string[list.Count * 2];

            for (int i = 0; i < list.Count; i++)
            {
                var currentNumber = list[i];
                var leftPart = currentNumber.Substring(0, currentNumber.IndexOf('.'));
                var rightPart = currentNumber.Substring(currentNumber.IndexOf('.') + 1);

                result[i] = leftPart.ToString();
                result[result.Length - 1 - i] = rightPart.ToString();
            }

            foreach (var text in result)
            {
                var num = int.Parse(text);
                if (num != 0)
                {
                    Console.Write(Convert.ToChar(num));
                }
            }
        }
    }
}
