namespace _04.Nilapdromes
{
    using System;
    using System.Text;

    public class Nilapdromes
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                var core = string.Empty;
                var leftSide = input.Substring(0, input.Length % 2 == 0 ? input.Length / 2 - 1 : input.Length / 2);
                var rightSide = input.Substring(input.Length % 2 == 0 ? input.Length / 2 + 1 : input.Length / 2 + 1);

                while (leftSide.Length > 0)
                {
                    if (rightSide.Contains(leftSide) && ((rightSide.LastIndexOf(leftSide) + leftSide.Length) == rightSide.Length))
                    {
                        core = leftSide;
                        break;
                    }
                    leftSide = leftSide.Remove(leftSide.Length - 1);
                }

                if (core.Length > 0)
                {
                    input = input.Remove(0, core.Length);
                    input = input.Remove(input.Length - core.Length);
                    Console.WriteLine($"{input}{core}{input}");
                }

                input = Console.ReadLine();
            }
        }

    }
}
