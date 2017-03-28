namespace _01.LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Lambada
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();
            var result = new Dictionary<string, string>();

            while (!input.Equals("lambada"))
            {
                if (input.Equals("dance"))
                {
                    result = new Dictionary<string, string>();
                    foreach (var kvp in dictionary)
                    {
                        var key = kvp.Key;
                        var list = kvp.Value.Split('.').ToList();
                        var value = list[0] +"."+ kvp.Value;
                        result[key] = value;
                    }
                }
                else
                {
                    var list = input.Split(" =>".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                    var selector = list[0];
                    var selectorAndProperty = list[1];
                    dictionary[selector] = selectorAndProperty;
                    result[selector] = selectorAndProperty;
                }
                input = Console.ReadLine();
                dictionary = result;
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp.Key + " => "+kvp.Value);
            }
        }
        
    }
}

