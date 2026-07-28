using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_2
{
    internal class Nine
    {
        public static void rep()
        {
            int[] arr = { 1, 2, 3, 2, 1, 4 };

            int xor = 0;

            // XOR of all elements
            for (int i = 0; i < arr.Length; i++)
            {
                xor = xor ^ arr[i];
            }

            // Rightmost set bit
            int setBit = xor & -xor;

            int num1 = 0;
            int num2 = 0;

            // Divide into two groups
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] & setBit) != 0)
                {
                    num1 = num1 ^ arr[i];
                }
                else
                {
                    num2 = num2 ^ arr[i];
                }
            }

            if (num1 < num2)
                Console.WriteLine(num1 + " " + num2);
            else
                Console.WriteLine(num2 + " " + num1);

            Console.ReadKey();
        }
    }
}

