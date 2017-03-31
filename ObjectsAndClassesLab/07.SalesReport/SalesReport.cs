using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var listOfSales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split().ToList();
                var sale = ReadSale(list[0], list[1], decimal.Parse(list[2]), decimal.Parse(list[3]));
                listOfSales.Add(sale);
            }

            var saleReport = new SortedDictionary<string, decimal>();

            foreach (var sale in listOfSales)
            {
                var town = sale.Town;
                if (!saleReport.ContainsKey(town))
                {
                    saleReport[town] = 0m;
                }

                saleReport[town] += (sale.Quantity * sale.Price);
            }

            foreach (var kvp in saleReport)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }
        }

        private static Sale ReadSale(string town, string product, decimal price, decimal quantity)
        {
            return new Sale
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = quantity
            };
        }

        public class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }
    }
}
