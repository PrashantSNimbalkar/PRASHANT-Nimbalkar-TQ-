using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{    static class Myclass
    {
        public static int x = 100;
        public static void read()
        {
            Console.WriteLine("HI THIS IS READ");
        }

    }
    class StaicclassDemo
    {static void Main (string[]args)
        {
            Console.WriteLine(Myclass.x);
            Myclass.read();
        }
    }
}

