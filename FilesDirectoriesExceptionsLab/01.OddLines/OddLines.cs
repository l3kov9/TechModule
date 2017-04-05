using System.IO;
using System.Linq;

namespace _01.OddLines
{
    public class OddLines
    {
        /*
         Write a program that reads a text file and writes its every odd line
         in another file. Line numbers starts from 0. 
         */

        public static void Main()
        {
            var text = File.ReadAllLines("input.txt");

            File.WriteAllLines("output.txt", text.Where((line, index) => index % 2 == 1));
        }
    }
}
