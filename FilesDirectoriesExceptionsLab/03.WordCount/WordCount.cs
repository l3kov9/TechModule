using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            //            Write a program that reads a list of words from the
            //file words.txt and finds how many times each of the words is contained in another file text.txt.
            //    Matching should be case-insensitive.
            //The result should be written to another text file. Sort the words by frequency in descending order. 

            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower()
                     .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
                wordCount[word] = 0;

            foreach (string word in text)
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;

            // Save the Output to a file

            foreach (var kvp in wordCount.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText("output.txt", $"{kvp.Key} - {kvp.Value}{Environment.NewLine}");
            }
        }
    }
}
