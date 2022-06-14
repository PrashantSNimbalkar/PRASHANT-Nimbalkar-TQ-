using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class XOBIN_ARRAY_PRIME_SUM
    {
        static void Main(string[] args)
        {
            
            
            int[] a = new int[5];
            int sum = 0;
            for (int i=0;i<a.Length;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            for (int i = 0; i < a.Length; i++)
            {
                int j = 2;
                int p = 1;
                
                while (j < a[i])
                {
                    if (a[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }
                if (p == 1)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
