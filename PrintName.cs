using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class PrintName
    {
        public static void print()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Name: " + name);
        }
    }
}