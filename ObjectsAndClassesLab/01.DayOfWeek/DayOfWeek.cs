namespace _01.DayOfWeek
{
    using System;
    using System.Globalization;
    public class DayOfWeek
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
