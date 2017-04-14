namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugsIndexes = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] ladybugs = new int[fieldSize];

            for (int i = 0; i < ladybugs.Length; i++)
            {
                if (ladybugsIndexes.Contains(i))
                {
                    ladybugs[i] = 1;
                }
                else
                {
                    ladybugs[i] = 0;
                }
            }

            var command = Console.ReadLine();

            while (!command.Equals("end"))
            {
                var commandList = command.Split().ToList();

                var ladybugIndex = int.Parse(commandList[0]);
                var direction = commandList[1];
                var flyLength = int.Parse(commandList[2]);

                if (direction.Equals("right") && ladybugIndex < ladybugs.Length
                    && ladybugIndex >= 0 && ladybugs[ladybugIndex] == 1)
                {
                    var destination = ladybugIndex + flyLength;
                    ladybugs[ladybugIndex] = 0;

                    while (destination < ladybugs.Length && destination >= 0 && ladybugs[destination] != 0)
                    {
                        destination += flyLength;
                    }
                    if (destination < ladybugs.Length && destination >= 0)
                    {
                        ladybugs[destination] = 1;
                    }
                }
                else if (direction.Equals("left") && ladybugIndex < ladybugs.Length
                    && ladybugIndex >= 0 && ladybugs[ladybugIndex] == 1)
                {
                    var destination = ladybugIndex - flyLength;
                    ladybugs[ladybugIndex] = 0;

                    while (destination < ladybugs.Length && destination >= 0 && ladybugs[destination] != 0)
                    {
                        destination -= flyLength;
                    }
                    if (destination < ladybugs.Length && destination >= 0)
                    {
                        ladybugs[destination] = 1;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", ladybugs));
        }
    }
}
