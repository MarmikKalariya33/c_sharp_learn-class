using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class butterfly
    {
        public static void but()
        {
            // first part 
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }

                // space print 
                int space = 2 * (5 - i);
                for(int j=1; j<=space; j++)
                {
                    Console.Write(" ");
                }

                // second part 
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            // half butterfly completed
             
            // sem copy and paste code only change first for loop 
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                int space = 2 * (5 - i);
                for (int j = 1; j <= space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

// *           *
// * *       * *
// * * *   * * *
// * * * * * * *
// * * * * * * *
// * * *   * * *
// * *       * *
// *           *