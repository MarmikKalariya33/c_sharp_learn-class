using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    internal class t3_12
    {
        // Properties
        public int EnrollmentNumber { get; set; }
        public string? Name { get; set; }

        public static void student()
        {
            t3_12 obj = new t3_12();

            // Accept student details
            Console.Write("Enter Enrollment Number: ");
            obj.EnrollmentNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            obj.Name = Console.ReadLine();

            // Display student details
            Console.WriteLine("\n===== STUDENT DETAILS =====");
            Console.WriteLine("Enrollment Number : " + obj.EnrollmentNumber);
            Console.WriteLine("Student Name      : " + obj.Name);
        }
    }
}