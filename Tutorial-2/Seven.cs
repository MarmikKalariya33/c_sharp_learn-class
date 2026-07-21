using System;

namespace c__learn.Tutorial_2
{
    internal class Seven
    {
        // Swap Method
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
    }

    class TestRef
    {
        public static void run()
        {
            Seven n = new Seven();

            // Local variables
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            // Calling swap method
            n.swap(ref a, ref b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}