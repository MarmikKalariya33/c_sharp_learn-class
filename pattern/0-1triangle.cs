using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class _0_1triangle
    {
        public static void tri()
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    int sum = i + j;
                    if(sum % 2 == 0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

// 1
// 0 1 
// 1 0 1
// 0 1 0 1 
// 1 0 1 0 1
