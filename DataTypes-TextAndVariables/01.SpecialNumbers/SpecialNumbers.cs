namespace _01.SpecialNumbers
{
    using System;
    public class SpecialNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                foreach (var item in i.ToString())
                {
                    sum += int.Parse(item.ToString());
                }
                Console.WriteLine("{0} -> {1}",i,sum==5 || sum==7 || sum==11);
            }
        }
    }
}
