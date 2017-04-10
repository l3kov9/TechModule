namespace _00.ReplaceTag
{
    using System;
    using System.Text.RegularExpressions;

    public class TagReplace
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = "<a\\s*href=(.+?\")>(\\w*)<\\/a>";
            var regex = new Regex(pattern);
            var replacement = "[URL href=$1]$2[/URL]";

            while (!input.Equals("end"))
            {
                var result = regex.Replace(input, replacement);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
