using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class StaticMethodOverLoad
    {
        static void addition()
        {
            Console.WriteLine(10 + 20);
        }
        static void addition(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void addition(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        static void addition(int x, int y, int z)
        {
            Console.WriteLine("ADDITION==" + (x + y + z));
        }
        static void Main(string[] args)
        {

            StaticMethodOverLoad.addition();
            StaticMethodOverLoad.addition(2,3);
            StaticMethodOverLoad.addition(2.3f,3.6f);
            StaticMethodOverLoad.addition(2,3,4);
        }
    }
}
