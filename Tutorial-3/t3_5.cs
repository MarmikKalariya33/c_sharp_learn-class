using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    internal class t3_5
    {
        public static void run()
        {
            Student s1 = new Student();
            Student s2 = new Student();

            Console.WriteLine("Enter Student 1 Details:");
            s1.AcceptData();

            Console.WriteLine("\nEnter Student 2 Details:");
            s2.AcceptData();

            Console.WriteLine("\nStudent 1 Details:");
            s1.Display();

            Console.WriteLine("\nStudent 2 Details:");
            s2.Display();
        }
    }
}