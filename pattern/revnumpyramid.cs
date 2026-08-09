using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.pattern
{
    internal class revnumpyramid
    {
        public static void inv()
        {
            for(int i=5; i>=1; i--)
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
