using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class USEofConstructor
    {
        int id;
        string name;
        int marks;
        public USEofConstructor(int sid,string sname,int mk)
        {
            id = sid;
            name = sname;
            marks = mk;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + marks);
        }
        static void Main(string[] args)
        {
            USEofConstructor s = new USEofConstructor(101, "PRASHANT", 100);
            s.display();
        }
    }
}
