namespace _05.NoteStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class NoteStatistics
    {
        public static void Main()
        {
            var list = Console.ReadLine().Split().Select(double.Parse).ToList();
            var notesList = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();
            double naturalSum = 0;
            double sharpsSum = 0;

            foreach (var num in list)
            {
                if(num== 261.63)
                {
                    notesList.Add("C");
                    naturals.Add("C");
                    naturalSum += num;
                }
                else if(num== 277.18)
                {
                    notesList.Add("C#");
                    sharps.Add("C#");
                    sharpsSum += num;
                }
                else if (num == 293.66)
                {
                    notesList.Add("D");
                    naturals.Add("D");
                    naturalSum += num;
                }
                else if (num == 311.13)
                {
                    notesList.Add("D#");
                    sharps.Add("D#");
                    sharpsSum += num;
                }
                else if (num == 329.63)
                {
                    notesList.Add("E");
                    naturals.Add("E");
                    naturalSum += num;
                }
                else if (num == 349.23)
                {
                    notesList.Add("F");
                    naturals.Add("F");
                    naturalSum += num;
                }
                else if (num == 369.99)
                {
                    notesList.Add("F#");
                    sharps.Add("F#");
                    sharpsSum += num;
                }
                else if (num == 392.00)
                {
                    notesList.Add("G");
                    naturals.Add("G");
                    naturalSum += num;
                }
                else if (num == 415.30)
                {
                    notesList.Add("G#");
                    sharps.Add("G#");
                    sharpsSum += num;
                }
                else if (num == 440.00)
                {
                    notesList.Add("A");
                    naturals.Add("A");
                    naturalSum += num;
                }
                else if (num == 466.16)
                {
                    notesList.Add("A#");
                    sharps.Add("A#");
                    sharpsSum += num;
                }
                else if (num == 493.88)
                {
                    notesList.Add("B");
                    naturals.Add("B");
                    naturalSum += num;
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ",notesList)}");
            Console.WriteLine($"Naturals: {string.Join(", ",naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {naturalSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");

            foreach (var sound in list)
            {
                Console.Beep((int)sound, 1000);
            }
        }
    }
}
