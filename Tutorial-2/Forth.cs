using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_2
{
    internal class Forth
    {
        public static void program()
        {
            int A, B;

            Console.Write("Enter A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter B: ");
            B = Convert.ToInt32(Console.ReadLine());

            // Arithmetic Operators
            Console.WriteLine("Addition = " + (A + B));
            Console.WriteLine("Subtraction = " + (A - B));
            Console.WriteLine("Multiplication = " + (A * B));
            Console.WriteLine("Division = " + (A / B));
            Console.WriteLine("Modulus = " + (A % B));

            // Relational Operators
            Console.WriteLine("A == B : " + (A == B));
            Console.WriteLine("A != B : " + (A != B));
            Console.WriteLine("A > B : " + (A > B));
            Console.WriteLine("A < B : " + (A < B));
            Console.WriteLine("A >= B : " + (A >= B));
            Console.WriteLine("A <= B : " + (A <= B));

            // Logical Operators
            Console.WriteLine("(A > 0 && B > 0) : " + (A > 0 && B > 0));
            Console.WriteLine("(A > 0 || B > 0) : " + (A > 0 || B > 0));
            Console.WriteLine("!(A > B) : " + !(A > B));

            // Assignment Operator
            int C = A;
            C += B;
            Console.WriteLine("C += B : " + C);

            // Increment / Decrement
            A++;
            B--;
            Console.WriteLine("A++ = " + A);
            Console.WriteLine("B-- = " + B);

            Console.ReadLine();
        }
    }
}
