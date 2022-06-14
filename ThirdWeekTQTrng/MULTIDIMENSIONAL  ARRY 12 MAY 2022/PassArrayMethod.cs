using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class PassArrayMethod
    {
        public static void primecheck(int[]a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                bool isprime = true;
                int n = a[i];
                for(int j=2;j<n;j++)
                {
                    if(n%j==0)
                    {
                        isprime = false;
                        break;
                    }

                }
                if(isprime==true)
                {
                    Console.WriteLine(a[i]+"  Is a  Prime");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 7, 8, 4, 2, 7, 9, 7, 3, 9 };
            PassArrayMethod.primecheck(a);
        }
    }
}
