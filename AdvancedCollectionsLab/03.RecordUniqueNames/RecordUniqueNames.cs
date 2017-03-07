﻿namespace _03.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RecordUniqueNames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                set.Add(name);
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
