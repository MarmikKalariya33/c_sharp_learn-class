using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn
{
     internal class @foreach
    {
        public static void foreachloop()
        {
            string name, result = "";

            Console.Write("enter a string : ");
            name = Console.ReadLine();

            foreach (char ch in name)
            {
                if (char.IsUpper(ch))
                {
                    result += char.ToLower(ch);
                }
                else if (char.IsLower(ch))
                {
                    result += char.ToUpper(ch);                  
                }
                else
                {
                    result += ch;
                }
            }
            Console.WriteLine("Toogle Case " + result);
            Console.WriteLine();
        }
    }
}
