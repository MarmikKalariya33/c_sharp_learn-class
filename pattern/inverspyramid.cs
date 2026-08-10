using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class inverspyramid
    {
        public static void inv()
        {
            for(int i=4; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            }
        }
    }

// * * * *
// * * * 
// * *
// *
