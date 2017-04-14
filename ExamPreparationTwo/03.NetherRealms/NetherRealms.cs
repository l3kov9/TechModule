namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {

        public class Demon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Damage { get; set; }
        }

        public static void Main()
        {
            var demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var healthRegex = new Regex(@"[^\d\+\-\*\/\.]");
            var damageRegex = new Regex(@"(\+|\-)?\d+(\.\d+)?");

            var demonsList = new List<Demon>();

            foreach (var demon in demons)
            {
                var monster = new Demon();
                monster.Name = demon;
                var healthMatches = healthRegex.Matches(demon);
                monster.Health = 0;

                foreach (Match letter in healthMatches)
                {
                    monster.Health += Convert.ToChar(letter.Value);
                }

                var damageMatches=damageRegex.Matches(demon);
                monster.Damage = 0.0;

                foreach (Match number in damageMatches)
                {
                    monster.Damage += double.Parse(number.Value);
                }

                foreach (var letter in demon)
                {
                    if (letter.Equals('*'))
                    {
                        monster.Damage *= 2.0;
                    }
                    if (letter.Equals('/'))
                    {
                        monster.Damage /= 2.0;
                    }
                }
               
                demonsList.Add(monster);
            }

            foreach (var monster in demonsList.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{monster.Name} - {monster.Health} health, {monster.Damage:f2} damage");
            }
        }
    }
}
