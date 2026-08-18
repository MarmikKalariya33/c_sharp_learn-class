using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    internal class t3_14
    {
        // Private salary - cannot be accessed directly
        private double salary;

        // Public method to set salary
        public void SetSalary(double amount)
        {
            if (amount > 0)
            {
                salary = amount;
                Console.WriteLine("Salary updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid salary amount.");
            }
        }

        // Public method to get salary
        public double GetSalary()
        {
            return salary;
        }

        public static void employee()
        {
            t3_14 obj = new t3_14();

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            // Controlled access through public method
            obj.SetSalary(salary);

            // Display employee details
            Console.WriteLine("\n========== EMPLOYEE DETAILS ==========");
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Salary: " + obj.GetSalary());
        }
    }
}