namespace _04.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CottageScraper
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var typeHeightDictionary = new Dictionary<string, List<double>>();
            var count = 0;

            while (!input.Equals("chop chop"))
            {
                var list = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                var type = list[0];
                var height = double.Parse(list[list.Count - 1]);
                AddToTypeHeightDictionary(typeHeightDictionary, type, height);
                
                input = Console.ReadLine();
                count++;
            }

            var typeOfTree = Console.ReadLine();
            var minimumLenghtPerTree = double.Parse(Console.ReadLine());

            var sumAllLog = 0.0;
            foreach (var list in typeHeightDictionary.Values)
            {
                foreach (var num in list)
                {
                    sumAllLog += num;
                }
            }
            var pricePerMeter = Math.Round(sumAllLog / (double)count,2);
            var usedLogPrice = typeHeightDictionary[typeOfTree].Where(x => x > minimumLenghtPerTree).Sum()*pricePerMeter;
            var unusedLogPrice = (sumAllLog - (typeHeightDictionary[typeOfTree].Where(x => x > minimumLenghtPerTree).Sum())) * pricePerMeter*0.25;
            var subTotal = usedLogPrice + unusedLogPrice;

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${subTotal:f2}");
        }

        private static void AddToTypeHeightDictionary(Dictionary<string, List<double>> typeHeightDictionary,
            string type, double height)
        {
            if (!typeHeightDictionary.ContainsKey(type))
            {
                typeHeightDictionary[type] = new List<double>();
            }

            typeHeightDictionary[type].Add(height);
        }
    }
}
