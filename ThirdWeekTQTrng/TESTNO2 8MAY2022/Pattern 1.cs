using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.TESTNO2_8MAY2022
{
    class Pattern_1
    {
        static void Main(string[] args)
        {
            int i, j;
            int k;
            for (i = 1; i <= 5; i++)
            {
                for (j=1;j<=i;j++)
                {
                    k = i;
                    Console.Write(k);
                    k--;
                }
            }
            Console.WriteLine();
        }
    }
}
