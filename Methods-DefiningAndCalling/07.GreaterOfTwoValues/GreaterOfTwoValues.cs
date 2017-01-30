namespace _07.GreaterOfTwoValues
{
    using System;
    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    {
                        int value1 = int.Parse(Console.ReadLine());
                        int value2 = int.Parse(Console.ReadLine());
                        int biggerValue = GetMax(value1, value2);
                        Console.WriteLine(biggerValue);
                        break;
                    }
                case "char":
                    {
                        char value1 = char.Parse(Console.ReadLine());
                        char value2 = char.Parse(Console.ReadLine());
                        char biggerValue = GetMax(value1, value2);
                        Console.WriteLine(biggerValue);
                        break;
                    }
                case "string":
                    {
                        string value1 = Console.ReadLine();
                        string value2 = Console.ReadLine();
                        string biggerValue = GetMax(value1, value2);
                        Console.WriteLine(biggerValue);
                        break;
                    }
            }
        }

        private static int GetMax(int value1, int value2)
        {
            return Math.Max(value1, value2);
        }

        private static char GetMax(char value1, char value2)
        {
            int biggerCharAsInt = GetMax((int)value1, (int)value2);
            return (char)biggerCharAsInt;

        }

        private static string GetMax(string value1, string value2)
        {
            if (value1.CompareTo(value1) > 0)
                return value1;
            else
                return value2;
        }
    }
}
