using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class mr
    {
        public static void hello()
        {
            string name;
            char gender;

            Console.WriteLine("enter name : ");
            name = Console.ReadLine();

            Console.WriteLine("enter gender (M/F):");
            gender = Convert.ToChar(Console.ReadLine());

            if (gender == 'M' || gender == 'm')
            {
                Console.WriteLine("Mr" + name);
            }
            else if (gender == 'F' || gender == 'f')
            {
                Console.WriteLine("Ms" + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
            Console.ReadLine();
        }
    }
}
