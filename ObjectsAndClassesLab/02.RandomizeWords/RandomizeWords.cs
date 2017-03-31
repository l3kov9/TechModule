namespace _02.RandomizeWords
{
    using System;
    using System.Linq;
    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToList();
            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                var randomIndex = rnd.Next(0, words.Count);

                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
