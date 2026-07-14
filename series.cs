using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class series
    {
        public static void sumseries()
        {
            int terms , number;
            int sum = 0;
            int Current = 0;
            Console.WriteLine("Enter Terms");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= terms; i++)
            {
                Current = Current + 10 + number;
                Console.Write(Current);
                sum += Current;

                if (i < terms)
                    Console.Write(" + ");
            }
            Console.WriteLine("sum is " + sum);
            Console.ReadLine();
        }
    }
}
