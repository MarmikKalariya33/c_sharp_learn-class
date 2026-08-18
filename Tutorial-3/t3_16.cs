using System;

namespace c__learn.Tutorial_3
{
    internal class t3_16
    {
        public static void employee()
        {
            Console.WriteLine("========== EMPLOYEE SALARY ==========");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Developer");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Manager obj = new Manager();

                Console.Write("\nEnter Employee ID: ");
                obj.EmployeeId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                obj.Name = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                obj.BasicSalary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Bonus: ");
                obj.Bonus = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n========== MANAGER DETAILS ==========");
                obj.DisplayDetails();
            }
            else if (choice == 2)
            {
                Developer obj = new Developer();

                Console.Write("\nEnter Employee ID: ");
                obj.EmployeeId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                obj.Name = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                obj.BasicSalary = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Project Allowance: ");
                obj.ProjectAllowance = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n========== DEVELOPER DETAILS ==========");
                obj.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }

    // Base class
    class Employee
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public double BasicSalary { get; set; }
    }

    // Derived class - Manager
    class Manager : Employee
    {
        public double Bonus { get; set; }

        public void DisplayDetails()
        {
            double salary = BasicSalary + Bonus;

            Console.WriteLine("Employee ID   : " + EmployeeId);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("Basic Salary  : " + BasicSalary);
            Console.WriteLine("Bonus         : " + Bonus);
            Console.WriteLine("Total Salary  : " + salary);
        }
    }

    // Derived class - Developer
    class Developer : Employee
    {
        public double ProjectAllowance { get; set; }

        public void DisplayDetails()
        {
            double salary = BasicSalary + ProjectAllowance;

            Console.WriteLine("Employee ID        : " + EmployeeId);
            Console.WriteLine("Employee Name      : " + Name);
            Console.WriteLine("Basic Salary       : " + BasicSalary);
            Console.WriteLine("Project Allowance  : " + ProjectAllowance);
            Console.WriteLine("Total Salary       : " + salary);
        }
    }
}