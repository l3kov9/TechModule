using System;
using System.IO;

namespace _2.LineNumbers
{
    public class LineNumbers
    {
        /*
         * Write a program that reads a text file and inserts line
         *  numbers in front of each of its lines.
         *   The result should be written to another text file. 
         */

        public static void Main()
        {
            var text = File.ReadAllLines("input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", $"{i + 1}. {text[i]}{Environment.NewLine}");
            }
        }
    }
}
