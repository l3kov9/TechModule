namespace _03.Pyramidic
{
    using System;
    using System.Collections.Generic;

    public class Pyramidic
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            var maxCounter = 1;
            var maxChar = ' ';

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }

            for (int i = 0; i < list.Count; i++)
            {
                var stringLength = 1;
                var counter = 1;

                foreach (var letter in list[i])
                {

                    while (i+1<list.Count && list[i + 1].Contains(new string(letter,stringLength+2)))
                    {
                        counter++;
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maxChar = letter;
                        }
                        i++;
                        stringLength += 2;
                    }
                }
            }

            var count = 1;

            for (int i = 0; i < maxCounter; i++)
            {
                Console.WriteLine(new string(maxChar,count));
                count += 2;
            }           
        }
    }
}
