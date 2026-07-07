using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
    internal class mobilenum
    {
        public static void mobilenumber()
        {
            string number;
            Console.Write("enter a mobile num : ");
            Console.ReadLine();
            if (number.Length >= 5)
            {
                string result = number.Substring(0, number.Length - 5) + "XXXXX";
                Console.WriteLine(result);
            }
            Console.ReadLine();

        }
    }
}
