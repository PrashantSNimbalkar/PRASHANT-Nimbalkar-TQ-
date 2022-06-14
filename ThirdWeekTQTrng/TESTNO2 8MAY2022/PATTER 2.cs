using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.TESTNO2_8MAY2022
{
    class PATTER_2
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for(i=1;i<=5;i++)
            {
                for(k=4;k>=i;k--)
                {
                    Console.Write("      ");

                }
                for(j=1;j<=i;j++)
                {
                    if(j%2==0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(1);
                    }
                }
            }
            
        }
     
    }
}
