using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class floydnum
    {
        public static void fly()
        {
            int num = 1;
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}

// 1
// 2  3
// 4  5  6 
// 7  8  9 10
// 11 12 13 14 15 
