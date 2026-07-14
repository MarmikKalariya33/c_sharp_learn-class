using System;

namespace c__learn
{
    internal class mobilenum
    {
        public static void mobilenumber()
        {
            Console.Write("Enter a mobile number: ");
            string number = Console.ReadLine();

            if (number.Length >= 5)
            {
                string result = number.Substring(0, number.Length - 5) + "XXXXX";
                Console.WriteLine("Masked Number: " + result);
            }
            else
            {
                Console.WriteLine("Please enter at least 5 digits.");
            }

            Console.ReadLine();
        }
    }
}