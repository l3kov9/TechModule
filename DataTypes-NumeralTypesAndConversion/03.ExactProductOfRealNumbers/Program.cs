using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactProductOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum=1;
            for (int i = 0; i < n; i++)
            {
                sum *= decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
