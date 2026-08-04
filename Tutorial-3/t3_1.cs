using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    class Student
    {
        private string Enrollment_No;
        private string Name;
        private string Branch;

        public void AcceptData()
        {
            Console.WriteLine("Enrollment No:");
            Enrollment_No = Console.ReadLine();

            Console.WriteLine("Name");
            Name = Console.ReadLine();

            Console.WriteLine("Branch");
            Branch = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine(Enrollment_No);
            Console.WriteLine(Name);
            Console.WriteLine(Branch);
        }
    }
    internal class t3_1
    {
        public static void run()
        {
            Student s1 = new Student();
            s1.AcceptData();
            s1.Display();
        }
    }
}
