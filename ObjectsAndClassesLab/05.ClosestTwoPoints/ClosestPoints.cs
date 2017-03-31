using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    public class ClosestPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var listOfPoints = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split().Select(int.Parse).ToList();
                var point = ReadPoint(list[0], list[1]);
                listOfPoints.Add(point);
            }

            var shortestDistance = double.MaxValue;
            Point firstResultPoint = null;
            Point secondResultPoint = null;

            for (int i = 0; i < listOfPoints.Count-1; i++)
            {
                for (int j = i+1; j < listOfPoints.Count; j++)
                {
                    var distance=CalcDistance(listOfPoints[i], listOfPoints[j]);
                    if (distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        firstResultPoint = listOfPoints[i];
                        secondResultPoint = listOfPoints[j];
                    }
                }
            }

            Console.WriteLine($"{shortestDistance:f3}");
            Console.WriteLine($"({firstResultPoint.X}, {firstResultPoint.Y})");
            Console.WriteLine($"({secondResultPoint.X}, {secondResultPoint.Y})");

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
