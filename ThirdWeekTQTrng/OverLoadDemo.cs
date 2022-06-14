using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class OverLoadDemo
    {
        void addition()
        {
            Console.WriteLine(10 + 20);
        }
        void addition(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        void addition(float a,float b)
        {
            Console.WriteLine(a+b);
        }
        void addition(int x, int y,int z)
        {
            Console.WriteLine("ADDITION=="+(x + y + z));
        }
        static void Main(string[]args)
        {
            OverLoadDemo d = new OverLoadDemo();
            d.addition(3.4f, 7.7f);
            d.addition();
            d.addition(4,5,3);
            d.addition(1,2);
        }
    }   
}
