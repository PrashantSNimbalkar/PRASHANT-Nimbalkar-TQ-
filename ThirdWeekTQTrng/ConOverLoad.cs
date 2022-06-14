using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class ConOverLoad
    {
        public ConOverLoad()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR");
        }
        public ConOverLoad(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public ConOverLoad(int x)
        {
            Console.WriteLine(x);
        }
        public ConOverLoad(float x,float y)
        {
            Console.WriteLine(x*y);
        }
        public ConOverLoad(float x)
        {
            Console.WriteLine(x*x*x);
        }
        static void Main(string[] args)
        {
            ConOverLoad a = new ConOverLoad();
            ConOverLoad b = new ConOverLoad(2);
            ConOverLoad c = new ConOverLoad(4,3);
            ConOverLoad d = new ConOverLoad(2.1f,3.4f);
            ConOverLoad e = new ConOverLoad(2.7f);
        } 
    }
}

