namespace _15.Calculator
{
    using System;
    public class Calculator
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            char operation = Convert.ToChar(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case '+': Console.WriteLine($@"{a} + {b} = {a+b}");break;
                case '-': Console.WriteLine($@"{a} - {b} = {a - b}"); break;
                case '*': Console.WriteLine($@"{a} * {b} = {a * b}"); break;
                case '/': Console.WriteLine($@"{a} / {b} = {a / b}"); break;
            }
        }
    }
}
