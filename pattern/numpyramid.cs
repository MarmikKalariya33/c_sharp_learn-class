using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class numpyramid
    {
        public static void num()
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

// 1
// 1 2 
// 1 2 3 
// 1 2 3 4 
// 1 2 3 4 5
