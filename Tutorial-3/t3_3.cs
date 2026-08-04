using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace c__learn.Tutorial_3
{
    class student
    {
        public int id;
        public string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public student()
        {
            id = 0;
            name = "marmik";
        }
        public student(int i , string n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Name:" + name);
        }
    }
    internal class t3_3
    {
        public static void run()
        {
            student stu = new student();
            stu.display();
        }
    }
}
