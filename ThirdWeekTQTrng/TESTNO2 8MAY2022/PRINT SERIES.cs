using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.TESTNO2_8MAY2022
{
    class PRINT_SERIES
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 20;
            int i;
            int j = 3;
            Console.WriteLine(0);
            for (i = 1; i <= num; i++)
            {
                for (; j <=(num*2)+1; j=j+2)
                {
                    int r = j;
                    sum = sum + r;
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
