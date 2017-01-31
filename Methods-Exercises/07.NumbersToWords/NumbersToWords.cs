namespace _07.NumbersToWords
{
    using System;
    public class NumbersToWords
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < -999)
                {
                    Console.Write("too small");
                }
                else if(number<100 && number > -100)
                {

                }
                else if (number > 999)
                {
                    Console.Write("too large");
                }
                else
                {
                    if (number < 0)
                    {
                        Console.Write("minus ");
                    }
                    number = Math.Abs(number);
                    int firstDigit = number / 100;
                    int secondDigit = (number / 10) % 10;
                    int thirdDigit = number % 10;

                    switch (firstDigit)
                    {
                        case 1: Console.Write("one-hundred"); break;
                        case 2: Console.Write("two-hundred"); break;
                        case 3: Console.Write("three-hundred"); break;
                        case 4: Console.Write("four-hundred"); break;
                        case 5: Console.Write("five-hundred"); break;
                        case 6: Console.Write("six-hundred"); break;
                        case 7: Console.Write("seven-hundred"); break;
                        case 8: Console.Write("eight-hundred"); break;
                        case 9: Console.Write("nine-hundred"); break;
                    }

                    if (secondDigit == 1)
                    {
                        switch (thirdDigit)
                        {
                            case 0: Console.Write(" and ten"); break;
                            case 1: Console.Write(" and eleven"); break;
                            case 2: Console.Write(" and twelve"); break;
                            case 3: Console.Write(" and thirteen"); break;
                            case 4: Console.Write(" and fourteen"); break;
                            case 5: Console.Write(" and fifteen"); break;
                            case 6: Console.Write(" and sixteen"); break;
                            case 7: Console.Write(" and seventeen"); break;
                            case 8: Console.Write(" and eighteen"); break;
                            case 9: Console.Write(" and nineteen"); break;
                        }
                    }
                    else if (secondDigit == 0)
                    {
                        switch (thirdDigit)
                        {
                            case 1: Console.Write(" and one"); break;
                            case 2: Console.Write(" and two"); break;
                            case 3: Console.Write(" and three"); break;
                            case 4: Console.Write(" and four"); break;
                            case 5: Console.Write(" and five"); break;
                            case 6: Console.Write(" and six"); break;
                            case 7: Console.Write(" and seven"); break;
                            case 8: Console.Write(" and eight"); break;
                            case 9: Console.Write(" and nine"); break;
                        }
                    }
                    else
                    {
                        switch (secondDigit)
                        {
                            case 2: Console.Write(" and twenty"); break;
                            case 3: Console.Write(" and thirty"); break;
                            case 4: Console.Write(" and fourty"); break;
                            case 5: Console.Write(" and fifty"); break;
                            case 6: Console.Write(" and sixty"); break;
                            case 7: Console.Write(" and seventy"); break;
                            case 8: Console.Write(" and eighty"); break;
                            case 9: Console.Write(" and ninety"); break;
                        }
                        switch (thirdDigit)
                        {
                            case 1: Console.Write(" one"); break;
                            case 2: Console.Write(" two"); break;
                            case 3: Console.Write(" three"); break;
                            case 4: Console.Write(" four"); break;
                            case 5: Console.Write(" five"); break;
                            case 6: Console.Write(" six"); break;
                            case 7: Console.Write(" seven"); break;
                            case 8: Console.Write(" eight"); break;
                            case 9: Console.Write(" nine"); break;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
