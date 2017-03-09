namespace _02.DictRefAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var seps = new char[] { '>', ' ', ',' };
            var dict = new Dictionary<string, List<string>>();
            var result = 0;

            while (!input.Equals("end"))
            {
                var list = input.Split('-').ToList();
                var name = list[0].Trim();
                var listOfGrades = list[1].Split(seps, StringSplitOptions.RemoveEmptyEntries).ToList();
                if(int.TryParse(listOfGrades[0], out result))
                {
                    AddToDictionary(name, listOfGrades, dict);
                }
                else
                {
                    if (dict.ContainsKey(listOfGrades[0]))
                    {
                        dict[name] = new List<string>();
                        dict[name].AddRange(dict[listOfGrades[0]]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} === {string.Join(", ",kvp.Value)}");
            }
        }

        private static void AddToDictionary(string name, List<string> listOfGrades, Dictionary<string, List<string>> dict)
        {
            if (!dict.ContainsKey(name))
            {
                dict[name] = new List<string>();
            }
            
            dict[name].AddRange(listOfGrades);
        }
    }
}
