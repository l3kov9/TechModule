namespace _10.Ballistics_Training
{
    using System;
    using System.Linq;

    public class BallisticsTraining
    {
        public static void Main()
        {
            int[] planeTarget = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = planeTarget[0];
            int y = planeTarget[1];
            int startingX = 0;
            int startingY = 0;
            string[] commandArray = Console.ReadLine().Split();

            for (int i = 0; i < commandArray.Length; i++)
            {
                if (commandArray[i].Equals("right"))
                {
                    startingX += int.Parse(commandArray[i + 1]);
                }
                else if (commandArray[i].Equals("down"))
                {
                    startingY -= int.Parse(commandArray[i + 1]);
                }
                else if (commandArray[i].Equals("up"))
                {
                    startingY += int.Parse(commandArray[i + 1]);
                }
                else if (commandArray[i].Equals("left"))
                {
                    startingX -= int.Parse(commandArray[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{startingX}, {startingY}]");
            if (startingX == x && startingY == y)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }

        }
    }
}
