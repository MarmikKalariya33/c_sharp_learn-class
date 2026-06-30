using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class evenodd
    {
        public static void even()
        {
            int number;
            Console.WriteLine("Enter a number: ");

            string str = Console.ReadLine();

            number = Convert.ToInt32(str);

            if(number % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }
        }
    }
}
