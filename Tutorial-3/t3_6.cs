using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    internal class t3_6
    {
        class Student
        {
            // Data members to store student details
            private string Enrollment_No;
            private string Name;
            private string Branch;

            // Method to accept student details from user
            public void AcceptData()
            {
                // Accept enrollment number
                Console.WriteLine("Enrollment No:");
                Enrollment_No = Console.ReadLine();

                // Accept student name
                Console.WriteLine("Name:");
                Name = Console.ReadLine();

                // Accept student branch
                Console.WriteLine("Branch:");
                Branch = Console.ReadLine();
            }

            // Method to display student details
            public void Display()
            {
                // Display enrollment number
                Console.WriteLine(Enrollment_No);

                // Display student name
                Console.WriteLine(Name);

                // Display student branch
                Console.WriteLine(Branch);
            }
        }
        public static void six()
        {
            Student s1 = new Student();

            // Create second Student object
            Student s2 = new Student();

            // Accept details of first student
            Console.WriteLine("Enter Student 1 Details:");
            s1.AcceptData();

            // Accept details of second student
            Console.WriteLine("\nEnter Student 2 Details:");
            s2.AcceptData();

            // Display details of first student
            Console.WriteLine("\nStudent 1 Details:");
            s1.Display();

            // Display details of second student
            Console.WriteLine("\nStudent 2 Details:");
            s2.Display();
        }
    }
}
