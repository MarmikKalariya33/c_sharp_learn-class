using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_2
{
    internal class Second
    {
        public static void program()
        {
            int a = 100;

            // Check the boolean condition
            if (a < 20)
            {
                Console.WriteLine("a is less than 20");
            }
            else
            {
                // Missing statement-1
                Console.WriteLine("a is not less than 20");
            }

            // Missing statement-2
            Console.WriteLine("value of a is : {0}", a);

            Console.ReadLine();

        }
    }
}
