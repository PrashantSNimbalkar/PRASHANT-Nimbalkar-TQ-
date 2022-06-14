using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.TESTNO2_8MAY2022
{
    class MOVELOAD
    { 
        void addition(float a, float b)
        {
            Console.WriteLine(a + b);
        }
         void addition(int x, int y, int z)
        {
            Console.WriteLine("ADDITION==" + (x + y + z));
        }
        static void Main(string[] args)
        {
            MOVELOAD M = new MOVELOAD();
            M.addition(1, 2);

            M.addition(2.3f, 3.4f);
            M.addition(3,4,5);
        }
    }
}
