namespace _04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Websites
    {
        public class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Queries { get; set; }
        }

        public static void Main()
        {
            var input = Console.ReadLine();
            var websites = new List<Website>();

            while (!input.Equals("end"))
            {
                var list = input.Split(new[] { ' ', ',', '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var host = list[0];
                var domain = list[1];

                list.Remove(host);
                list.Remove(domain);

                var website = new Website
                {
                    Host = host,
                    Domain = domain,
                    Queries = new List<string>(list)
                };

                websites.Add(website);

                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Queries.Count > 0)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[",website.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }
    }
}
