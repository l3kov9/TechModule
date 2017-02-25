namespace _02.TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine().Split().ToList();
            var input = Console.ReadLine();
            var result = new List<string>();

            while (input!="end")
            {
                for (int i = 0; i < blackList.Count; i++)
                {
                    if (input.Contains(blackList[i]))
                    {
                        break;
                    }
                    if(i==blackList.Count-1 && !input.Contains(blackList[blackList.Count - 1]))
                    {
                        result.Add(input);
                    }
                }
                
                input = Console.ReadLine();
            }

            result.Sort();

            foreach (var song in result)
            {
                Console.WriteLine(song);
            }
        }
    }
}
