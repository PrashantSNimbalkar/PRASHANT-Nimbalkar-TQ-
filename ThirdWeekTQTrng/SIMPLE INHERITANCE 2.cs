using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{class Father
    {
        public int parent = 2;
    }
    class Son:Father
    {
        public void show()
        {
            Console.WriteLine(parent);
        }
    }
    class SIMPLE_INHERITANCE_2
    {
        static void Main(string[] args)
        {
            Son c = new Son();
            c.show();
        }
    }
}
