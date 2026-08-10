using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class inversehalf
    {
        public static void pym()
        {
            for(int i=1; i<=4; i++)
            {
                for(int j=1; j<=4-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            }
        }
    }

//       *
//     * *
//   * * *
// * * * *