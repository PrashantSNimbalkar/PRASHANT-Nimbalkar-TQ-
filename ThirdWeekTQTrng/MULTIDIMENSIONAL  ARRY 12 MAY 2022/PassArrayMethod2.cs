using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class PassArrayMethod2
    {       public static bool CheckArrayPrime(int n)
        {
            bool isprime = true;
            for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    isprime = false;
                    break;
                }
              
            }
            if (isprime == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 6, 7, 8, 4, 2, 7, 9, 7, 3, 9 };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                bool isprime = PassArrayMethod2.CheckArrayPrime(a[i]);
                if (isprime == true)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        
    }
}
