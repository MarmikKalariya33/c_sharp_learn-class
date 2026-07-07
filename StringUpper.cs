using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class StringUpper
    {
        public static void upper()
        {
            string name;
            Console.Write("Enter name to convert to uppercase : ");
            name = Console.ReadLine();

            Console.WriteLine("UpperCase Result is :" + name.ToUpper());
            Console.ReadLine();
        }
    }
}
