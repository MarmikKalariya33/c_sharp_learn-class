using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace c__learn
{
    internal class Isupper
    {
        public static void isupper()
        {
            string name , result = "";
            Console.Write("Enter a string: ");
            name = Console.ReadLine();

            Console.WriteLine("uppercase value is:" + name.ToUpper());
            Console.ReadLine();

            foreach (char ch in name)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if(char.IsLower(ch))
                {
                    result += char.ToUpper(ch);
                }
                else
                {
                    result += ch;
                }
                Console.WriteLine("Converted string: " + result);
                Console.ReadLine();
            }
        }
    }
}
