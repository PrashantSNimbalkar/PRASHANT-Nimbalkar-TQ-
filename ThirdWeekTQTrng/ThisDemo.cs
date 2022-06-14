using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class ThisDemo
    {
        int x = 10;
        public ThisDemo(): this (78)
        {
            Console.WriteLine("HI I AM DEFAULT CONSTRUCTOR");
        }
        public ThisDemo(int x)
        {
            Console.WriteLine("HII X----------"+x);
        }
        void Read(int x)
        {
            this.x = x;
            this.show();
        }
        void show()
        {
            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            ThisDemo d1 = new ThisDemo();
            d1.Read(500);
            d1.Read(100);
        }
    }
}
