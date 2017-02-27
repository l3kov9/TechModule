namespace _02.JapaneseRoulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class JapaneseRoulette
    {
        public static void Main()
        {
            var russianGun = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bulletIndex = 0;

            for (int i = 0; i < russianGun.Count; i++)
            {
                if (russianGun[i] == 1)
                {
                    bulletIndex = i;
                }
            }

            var playerShots = Console.ReadLine().Split().ToList();
            var startingIndex = -1;

            for (int i = 0; i < playerShots.Count; i++)
            {
                var currentIndex = startingIndex;
                var playerCommand = playerShots[i].Split(',').ToList();
                var power = int.Parse(playerCommand[0]);
                var direction = playerCommand[1];

                if (direction.Equals("Right"))
                {
                    for (int k = 0; k < power; k++)
                    {
                        currentIndex++;
                        if (currentIndex > 5)
                        {
                            currentIndex = 0;
                        }
                    }
                    var shotIndex = currentIndex + 1;
                    if (shotIndex == 6)
                    {
                        shotIndex = 0;
                    }

                    if (shotIndex == bulletIndex)
                    {
                        Console.WriteLine($"Game over! Player {i} is dead.");
                        return;
                    }
                }
                else if (direction.Equals("Left"))
                {
                    for (int k = 0; k < power; k++)
                    {
                        currentIndex--;
                        if (currentIndex < 0)
                        {
                            currentIndex = 5;
                        }
                    }
                    var shotIndex = currentIndex - 1;
                    if (shotIndex <0)
                    {
                        shotIndex = 5;
                    }

                    if (shotIndex == bulletIndex)
                    {
                        Console.WriteLine($"Game over! Player {i} is dead.");
                        return;
                    }
                }

                bulletIndex++;
                if (bulletIndex == 6)
                {
                    bulletIndex = 0;
                }

                startingIndex = currentIndex;
            }

            Console.WriteLine("Everybody got lucky!");
        }
    }
}
