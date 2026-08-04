using c__learn.Tutorial_3;
using System;
using System.Collections.Generic;
using System.Text;

namespace c__learn.Tutorial_3
{
    class students
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
        public students()
        {
            id = 0;
            name = "marmik";
        }
        public students(int i, string n)
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
}
    internal class t3_4
    {
    public static void run()
    {
        students stu1 = new students(101,"marmik");
        students stu2 = new students(102,"yash");
        students stu3 = new students(103,"pritesh");
        students stu4 = new students(104,"smit");
        students stu5 = new students(105,"aryan");

        stu1.display();
        stu2.display();
        stu3.display();
        stu4.display();
        stu5.display();
        Console.WriteLine();
        
    }
}
