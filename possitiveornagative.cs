using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class possitiveornagative
    {
        public static void posneg()
        {
            int number;
            Console.WriteLine("enter the number");
            string str = Console.ReadLine();
            number = Convert.ToInt32(str);
            if (number >= 1)
            {
                Console.WriteLine("number is possitive");
            }
            else if (number == 0)
            {

                Console.WriteLine("number is zero");
            }
            else
            {
                Console.WriteLine("negative number");
            }
        }
    }
}

