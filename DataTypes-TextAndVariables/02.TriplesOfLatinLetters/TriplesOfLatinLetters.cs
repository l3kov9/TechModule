namespace _02.TriplesOfLatinLetters
{
    using System;
    class TriplesOfLatinLetters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 'a'; i < 'a'+n; i++)
            {
                for (int j = 'a' ; j < 'a'+n; j++)
                {
                    for (int k = 'a'; k < 'a'+n; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
