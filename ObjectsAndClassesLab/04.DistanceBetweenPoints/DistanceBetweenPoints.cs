namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPointProperties = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPointProperties = Console.ReadLine().Split().Select(int.Parse).ToList();

            var firstPoint = ReadPoint(firstPointProperties[0], firstPointProperties[1]);
            var secondPoint = ReadPoint(secondPointProperties[0], secondPointProperties[1]);

            var totalDistance = CalculateDistanceBetweenPoints(firstPoint, secondPoint);
            Console.WriteLine($"{totalDistance:f3}");
        }

        private static Point ReadPoint(int x, int y)
        {
            return new Point
            {
                X = x,
                Y = y
            };
        }

        private static double CalculateDistanceBetweenPoints(Point firstPoint, Point secondPoint)
        {
            var a = Math.Abs(firstPoint.X - secondPoint.X);
            var b = Math.Abs(firstPoint.Y - secondPoint.Y);
            var distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
    }
}
