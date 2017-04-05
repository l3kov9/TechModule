using System;
using System.IO;
using System.Linq;

namespace _04.MergeFiles
{
    public class MergeFiles
    {
        // Write a program that reads the contents of two text files and merges them together into a third one.
        public static void Main()
        {
            var fileOne=File.ReadAllLines("FileOne.txt").ToList();
            var fileTwo = File.ReadAllLines("FileTwo.txt").ToList();

            fileOne.AddRange(fileTwo);

            for (int i = 0; i < fileOne.Count; i++)
            {
                File.AppendAllText("output.txt", fileOne[i]+Environment.NewLine);
            }
        }
    }
}
