namespace _19.TheaThePhotographer
{
    using System;
    public class TheaThePhotographer
    {
        public static void Main()
        {
            long countPictures = long.Parse(Console.ReadLine());
            long filterTimePic = long.Parse(Console.ReadLine());
            int percentageGoodPics = int.Parse(Console.ReadLine());
            long uploadTimePic = long.Parse(Console.ReadLine());

            long totalTime = countPictures * filterTimePic + ((long)Math.Ceiling(percentageGoodPics / 100.0 *countPictures)*uploadTimePic);

            TimeSpan t = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",t.Days,t.Hours,t.Minutes,t.Seconds);
        }
    }
}
