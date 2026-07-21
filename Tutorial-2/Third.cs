using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_2
{
    internal class Third
    {
        public static void program()
        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: " + firstName + " " + lastName);

            Console.ReadLine();
        }
    }
}
