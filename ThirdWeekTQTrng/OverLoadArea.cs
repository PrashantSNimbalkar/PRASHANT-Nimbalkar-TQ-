using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class OverLoadArea
    {
        void area(int x,int y)
        {
            int a = x * y;
            Console.WriteLine("AREA OF RECTNAGLE IS=:" + a);
        }
        void area(float x, float y)
        {
            float b= (x * y) / 2;
            Console.WriteLine("AREA OF TRIANGLE IS=:  " + b);
        }
        void area(float r)
        {
            float pi = 3.14f;
            float c = pi * r * r; ;
            Console.WriteLine("AREA OF CIRCLE IS=:" + c);
        }
        void area(int a)
        {
            int d = a * a;
            Console.WriteLine("AREA OF SQUARE IS=:" + d);
        }
        static void Main(string[] args)
        {
            OverLoadArea a = new OverLoadArea();
            a.area(2, 3);
            a.area(3.4f, 2.2f);
            a.area(4.3f);
            a.area(7);
        }
    }
}
