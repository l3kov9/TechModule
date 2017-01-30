namespace _05.CalculateTriangleArea
{
    using System;
    public class CalculateTriangleArea
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = TiangleArea(width, height);
            Console.WriteLine(area);
        }

        private static double TiangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
