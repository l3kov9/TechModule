namespace _02.IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class IntegerInsertion
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command!="end")
            {
                int index = int.Parse(command[0].ToString());
                list.Insert(index, int.Parse(command));

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
