using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng
{    static class ADDITION
    {
        static int num1 = 10;
        static int num2 = 20;
        static int num3 = 0;
        static ADDITION()
        {
            Console.WriteLine("THIS IS A DEFAUKT CONSTRUCTOR");
        }
        public static void add()
        {
            int Result = (num1 + num2 + num3);
            Console.WriteLine(Result);

        }
        
    }
    class ADDITIONDEMO
    {
        static void Main(string[] args)
        {
            {
                ADDITION.add();
            }
        }
    }
}
