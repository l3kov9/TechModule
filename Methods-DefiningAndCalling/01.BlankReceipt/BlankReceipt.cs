namespace _01.BlankReceipt
{
    using System;
    public class BlankReceipt
    {
        public static void Main()
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine(new string('-',30));
            Console.WriteLine("\u00A9 SoftUni");
        }

        private static void PrintBody()
        {
            Console.WriteLine($"Charged to{new string('_',20)}");
            Console.WriteLine($"Received by{new string('_',19)}");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-',30));
        }
    }
}
