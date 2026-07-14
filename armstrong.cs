using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class armstrong
    {
        public static void arm()
        {
            int number, original, remainder, result = 0;
            Console.Write("Enter a three-digit integer: ");
            number = Convert.ToInt32(Console.ReadLine());

            original = number;
            while (number != 0)
            {
                remainder = number % 10;
                result += remainder * remainder * remainder;
                number /= 10;
            }
            if (original == result)
            {
                Console.WriteLine($"{original} is an Armstrong number.");

            }
            else
            {
                Console.WriteLine($"{original} is not an Armstrong number.");
            }
            Console.ReadLine();
        }
    }
}