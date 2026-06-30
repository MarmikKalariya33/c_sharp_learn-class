using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class table
    {
        public static void multiplication()
        {
            int number;
            Console.WriteLine("enter the number");
            string str = Console.ReadLine();
            number = Convert.ToInt32(str);

            int Result;
            for (int i = 1; i <=10; i++)
            {
                Result = number * i;
                Console.WriteLine($"{number} * {i} = {Result}");
            }
        }
    }
}
