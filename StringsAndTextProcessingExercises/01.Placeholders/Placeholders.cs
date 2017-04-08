namespace _01.Placeholders
{
    using System;
    public class Placeholders
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                var inputLines = input.Split('-');
                var output = inputLines[0].Trim();
                var placeholders = inputLines[1].Substring(1).Trim().Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < placeholders.Length; i++)
                {
                    output = output.Replace("{" + i + "}", placeholders[i]);
                }

                Console.WriteLine(output);
                input = Console.ReadLine();
            }
        }
    }
}
