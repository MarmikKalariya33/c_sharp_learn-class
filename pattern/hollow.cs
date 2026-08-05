using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class hollow
    {
        public static void holo()
        {
            for(int i=1; i<=5; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    if (i == 1 || i == 5 || j==1 || j==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            }
        }
    }

// * * * * *
// *       *
// *       *
// *       *
// * * * * *