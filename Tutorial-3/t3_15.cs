using System;

namespace c__learn.Tutorial_3
{
    internal class t3_15
    {
        public static void student()
        {
            marmik obj = new marmik();  

            Console.Write("Enter Name: ");
            obj.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            obj.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address: ");
            obj.Address = Console.ReadLine();

            Console.Write("Enter Enrollment Number: ");
            obj.EnrollmentNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            obj.Course = Console.ReadLine();

            Console.Write("Enter Semester: ");
            obj.Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n========== STUDENT DETAILS ==========");
            obj.DisplayDetails();
        }
    }

    // Parent / Base class
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
    }

    // Child / Derived class
    class marmik : Person
    {
        public int EnrollmentNumber { get; set; }
        public string? Course { get; set; }
        public int Semester { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Name              : " + Name);
            Console.WriteLine("Age               : " + Age);
            Console.WriteLine("Address           : " + Address);
            Console.WriteLine("Enrollment Number : " + EnrollmentNumber);
            Console.WriteLine("Course            : " + Course);
            Console.WriteLine("Semester          : " + Semester);
        }
    }
}