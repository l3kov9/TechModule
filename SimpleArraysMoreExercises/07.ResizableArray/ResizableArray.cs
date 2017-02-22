namespace _07.ResizableArray
{
    using System;
    using System.Collections.Generic;

    public class ResizableArray
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            string[] command = Console.ReadLine().Split();

            while (command[0]!="end")
            {
                if (command[0].Equals("push"))
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0].Equals("pop"))
                {
                    list.RemoveAt(list.Count - 1);
                }
                else if (command[0].Equals("removeAt"))
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0].Equals("clear"))
                {
                    list.Clear();
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ",list));
        }
    }
}
