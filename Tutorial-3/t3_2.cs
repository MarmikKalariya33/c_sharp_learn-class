using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    class clock
    {
        private int hour;
        private int min;
        private int sec;

        public clock() 
        {
            hour = 12;
            min = 0;
            sec = 0;
        }
        public clock(int h, int m, int s)
        {
           this.hour = h;
           this.min = m;
           this.sec = s;
        }
        public void incrementTime()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;

                if (min == 60)
                {
                    min = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
        public void display()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }
        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return min;
        }

        public int getSeconds()
        {
            return sec;
        }
    };
    internal class t3_2
        {
            public static void run()
        {
            clock c1 = new clock();
            Console.WriteLine("Default time:");
            c1.display();

            clock c2 = new clock(10,25,50);
            Console.WriteLine("\nGiven Time:");
            c2.display();
            c2.incrementTime();

            Console.WriteLine("\n After Increment");
            c2.display();

            Console.WriteLine("\n Hour:" + c2.getHour());
            Console.WriteLine("\n Minit:" + c2.getMinute());
            Console.WriteLine("\n second:" + c2.getSeconds());
            }
        }
    }

