namespace _05.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Boxes
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                var list = input.Split(new[] { ':', ' ', '|' },StringSplitOptions.RemoveEmptyEntries).ToList();

                var upperLeft = ReadPoint(int.Parse(list[0]), int.Parse(list[1]));
                var upperRight = ReadPoint(int.Parse(list[2]), int.Parse(list[3]));
                var bottomLeft = ReadPoint(int.Parse(list[4]), int.Parse(list[5]));
                var bottomRight = ReadPoint(int.Parse(list[6]), int.Parse(list[7]));

                var perimeter = CalculatePerimeter(upperLeft, upperRight, bottomLeft, bottomRight);
                var area = CalculateArea(upperLeft, upperRight, bottomLeft, bottomRight);

                var width = CalcDistance(upperRight, upperLeft);
                var height = CalcDistance(upperLeft, bottomLeft);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");

                input = Console.ReadLine();
            }
        }

        private static double CalculateArea(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
        {
            var width = CalcDistance(upperRight, upperLeft);
            var height = CalcDistance(upperLeft, bottomLeft);

            return width * height;
        }

        private static double CalculatePerimeter(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
        {
            var width = CalcDistance(upperRight, upperLeft);
            var height = CalcDistance(upperLeft, bottomLeft);

            return (2 * width + 2 * height);
        }

        private static double CalcDistance(Point point1, Point point2)
        {
            var a = Math.Abs(point1.X - point2.X);
            var b = Math.Abs(point1.Y - point2.Y);
            var distance = Math.Sqrt(a * a + b * b);

            return distance;
        }

        private static Point ReadPoint(int x, int y)
        {
            return new Point
            {
                X = x,
                Y = y
            };
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
