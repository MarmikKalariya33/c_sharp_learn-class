using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class factorial
    {
        public static void fact()
        {
            int number;
            Console.WriteLine("Enter a number: ");
            string str = Console.ReadLine();
            number = Convert.ToInt32(str);
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {number} is {factorial}");
        }
    }
}
