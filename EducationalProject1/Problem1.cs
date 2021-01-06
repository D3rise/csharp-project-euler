using System;
using System.Collections.Generic;

namespace EducationalProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            int multipleNumbersSum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (IsDivisibleBy(i, 3) || IsDivisibleBy(i, 5))
                {
                    multipleNumbersSum += i;
                }
            }
            
            Console.WriteLine($"Sum of dividable numbers is: {multipleNumbersSum}");
        }

        static bool IsDivisibleBy(int number, int divider)
        {
            return number % divider == 0;
        }
    }
}