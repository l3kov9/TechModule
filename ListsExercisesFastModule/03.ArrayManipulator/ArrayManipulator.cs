namespace _03.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class ArrayManipulator
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command!="print")
            {
                var commandList = command.Split().ToList();

                if (commandList[0].Equals("add"))
                {
                    list.Insert(int.Parse(commandList[1]), int.Parse(commandList[2]));
                }
                else if (commandList[0].Equals("addMany"))
                {
                    var addingRange = new List<int>();
                    for (int i = 2; i < commandList.Count; i++)
                    {
                        addingRange.Add(int.Parse(commandList[i]));
                    }
                    list.InsertRange(int.Parse(commandList[1]),addingRange);
                }
                else if (commandList[0].Equals("contains"))
                {
                    Console.WriteLine(list.IndexOf(int.Parse(commandList[1])));
                }
                else if (commandList[0].Equals("remove"))
                {
                    list.RemoveAt(int.Parse(commandList[1]));
                }
                else if (commandList[0].Equals("shift"))
                {
                    for (int i = 0; i < int.Parse(commandList[1]); i++)
                    {
                        var firstNum = list[0];
                        list.RemoveAt(0);
                        list.Add(firstNum);
                    }
                }
                else if (commandList[0].Equals("sumPairs"))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if(i!=list.Count-1)
                        {
                            list[i] += list[i + 1];
                            list.RemoveAt(i + 1);
                        }
                    }
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("["+string.Join(", ",list)+"]");
        }
        
    }
}
