using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class StaticMethodDemo
    {
        static int y = 10;
        int x = 300;
        static StaticMethodDemo()
        {
            Console.WriteLine("HII THIS IS DEFAULT");
        }
        void show()
        {
            y = 40;
            Console.WriteLine("HII THIS IS SHOW   " + y + " " + x);
        }
        static void read()
        {
            StaticMethodDemo m = new StaticMethodDemo();
            Console.WriteLine("HII THIS IS READ   " + y + " " + m.x);
        }
        static void Main(string[] args)
        {
            StaticMethodDemo d = new StaticMethodDemo();
            d.show();
            StaticMethodDemo.read();
            StaticMethodDemo d1 = new StaticMethodDemo();
            StaticMethodDemo d2 = new StaticMethodDemo();
            /*  d.read();cannot access static merthod with object we can access with only class name*/
        }
    }
}
