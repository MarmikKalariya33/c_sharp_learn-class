using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class sum
    {
        public static void addition()
        {
            int a, b, c, sum;
            Console.WriteLine("enter the first number");
            string str1 = Console.ReadLine();
            a=Convert.ToInt32(str1);

            Console.WriteLine("enter the second number");
            string str2 = Console.ReadLine();
            b = Convert.ToInt32(str2);

            Console.WriteLine("enter the third number");
            string str3 = Console.ReadLine();
            c = Convert.ToInt32(str3);

            int addition = a + b + c;
            Console.WriteLine("the sum of three numbers is " + addition);
            
        }
    }
}
