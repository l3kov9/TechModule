namespace _06.MathPower
{
    using System;
    public class MathPower
    {
        public static void Main()
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double mathPowerOfNum = MathPowerValue(num,power);
            Console.WriteLine(mathPowerOfNum);
        }

        private static double MathPowerValue(double num,int power)
        {
            return Math.Pow(num, power);
        }
    }
}
