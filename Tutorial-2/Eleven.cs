using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_2
{
    internal class Eleven
    {
        public static void program()
        {
            int n, sum = 0;
            Console.WriteLine("enter size");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter element");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("sum = " + sum);
        }
    }
}
