using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace c__learn.String
{
    internal class reverse
    {
      public static void str()
        {
            string name, rev = "";
            Console.WriteLine("Enter the string");
            name = Console.ReadLine();
            for (int i = name.Length-1;i>=0; i--)
            {
                rev = rev + name[i]; 
            }
            Console.WriteLine(rev);
            if (rev == name)
            {
                Console.WriteLine("number is palindrom");
            }
            else
            {
                Console.WriteLine("number is not palindrom");
            }
        }
    }
}
