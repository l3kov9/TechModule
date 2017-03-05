namespace _06.FilterBase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FilterBase
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var ageDictionary = new Dictionary<string, int>();
            var salaryDictionary = new Dictionary<string, double>();
            var positionDictionary = new Dictionary<string, string>();

            while (!input.Equals("filter base"))
            {
                var list = input.Split().ToList();
                var name = list[0];
                var secondElement = list[2];
                var integer = 0;
                var doubleNumber = 0.0;

                var isInteger = int.TryParse(secondElement, out integer);
                var isDoubleNumber = double.TryParse(secondElement, out doubleNumber);
                if (isInteger)
                {
                    ageDictionary[name] = int.Parse(secondElement);
                }
                else if (isDoubleNumber)
                {
                    salaryDictionary[name] = double.Parse(secondElement);
                }
                else
                {
                    positionDictionary[name] = secondElement;
                }

                input = Console.ReadLine();
            }

            var printingElements = Console.ReadLine();
            switch (printingElements)
            {
                case "Age":
                    {
                        foreach (var kvp in ageDictionary)
                        {
                            Console.WriteLine($"Name: {kvp.Key}");
                            Console.WriteLine($"Age: {kvp.Value}");
                            Console.WriteLine(new string('=',20));
                        }
                    }
                    break;
                case "Salary":
                    {
                        foreach (var kvp in salaryDictionary)
                        {
                            Console.WriteLine($"Name: {kvp.Key}");
                            Console.WriteLine($"Salary: {kvp.Value:f2}");
                            Console.WriteLine(new string('=', 20));
                        }
                    }
                    break;
                case "Position":
                    {
                        foreach (var kvp in positionDictionary)
                        {
                            Console.WriteLine($"Name: {kvp.Key}");
                            Console.WriteLine($"Position: {kvp.Value}");
                            Console.WriteLine(new string('=', 20));
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
