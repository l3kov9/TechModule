namespace _01.RabbitHole
{
    using System;
    using System.Linq;
    public class RabbitHole
    {
        public static void Main()
        {
            var commands = Console.ReadLine().Split().ToList();
            var energy = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands.Count; i++)
            {
                var commandList = commands[i].Split('|').ToList();

                if (commandList[0].Equals("RabbitHole"))
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    return;
                }
                else if (commandList[0].Equals("Left"))
                {
                    for (int k = 0; k < int.Parse(commandList[1]); k++)
                    {
                        i--;
                        if (i < 0)
                        {
                            i = commands.Count - 1;
                        }
                    }
                    energy -= int.Parse(commandList[1]);
                }
                else if (commandList[0].Equals("Right"))
                {
                    for (int k = 0; k < int.Parse(commandList[1]); k++)
                    {
                        i++;
                        if (i > commandList.Count-1)
                        {
                            i = 0;
                        }
                    }
                    energy -= int.Parse(commandList[1]);
                }
                else if (commandList[0].Equals("Bomb"))
                {
                    energy -= int.Parse(commandList[1]);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        return;
                    }
                    commands.RemoveAt(i);
                    i = 0;
                }
                if (energy <= 0)
                {
                    Console.WriteLine("You are tired. You can't continue the mission.");
                    return;
                }

                var currentEnergy = energy.ToString();
                string lastCommand = commands[commands.Count - 1];
                string bombAdd = $"Bomb|{currentEnergy}";
                if (lastCommand.Equals("RabbitHole"))
                {
                    commands.Add(bombAdd);
                }
                else
                {
                    commands.Add(bombAdd);
                    commands.RemoveAt(commands.Count - 2);
                }
            }
        }
    }
}
