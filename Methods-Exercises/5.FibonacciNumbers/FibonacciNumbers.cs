namespace _5.FibonacciNumbers
{
    using System;
    public class FibonacciNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            PrintFibonacci(number);
        }

        private static void PrintFibonacci(int number)
        {
            int firstNum = 1;
            int secondNum = 1;
            int result = 0;
            for (int i = 0; i < number; i++)
            {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;
            }
            Console.WriteLine(firstNum);
        }
    }
}
