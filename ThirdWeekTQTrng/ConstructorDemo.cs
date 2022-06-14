using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("HII I AM A DEFAULT CONSTRUCTOR");
        }
        public ConstructorDemo(int x)
        {
            Console.WriteLine("PARAMATRIC CONSTRUCTOR");
        }
        static ConstructorDemo()
        {
            Console.WriteLine("STATIC CONSTRUCTOR");
        }
        public void add()
        {

        }
        private ConstructorDemo(string name)
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            ConstructorDemo d = new ConstructorDemo();
            ConstructorDemo d1 = new ConstructorDemo(5);

            ConstructorDemo d3 = new ConstructorDemo("PUNE");
            Demo demo = new Demo();
            demo.print();
        }

    }
    class Demo
    {
        public void print()
        {
            ConstructorDemo c = new ConstructorDemo();

        }
    }
}


