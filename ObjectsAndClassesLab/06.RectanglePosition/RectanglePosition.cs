namespace _06.RectanglePosition
{
    using System;
    using System.Linq;

    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectProp = Console.ReadLine().Split().Select(int.Parse).ToList();
            var firstRectangle = ReadRectangle(firstRectProp[0], firstRectProp[1], firstRectProp[2], firstRectProp[3]);

            var secondRectProp = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondRectangle = ReadRectangle(secondRectProp[0], secondRectProp[1], secondRectProp[2], secondRectProp[3]);

            var isInside = CheckPositions(firstRectangle, secondRectangle);

            Console.WriteLine(isInside?"Inside":"Not inside");
        }

        private static bool CheckPositions(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            var isInside = false;
            if(firstRectangle.Left>=secondRectangle.Left
                &&firstRectangle.Top<=secondRectangle.Top
                &&firstRectangle.Width<=secondRectangle.Width
                &&firstRectangle.Height<=secondRectangle.Height
                )
            {
                isInside=true;
            }

            return isInside; 
        }

        private static Rectangle ReadRectangle(int left, int top, int width, int height)
        {
            return new Rectangle
            {
                Left = left,
                Top = top,
                Width = width,
                Height = height
            };
        }

        public class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

        }
    }
}
