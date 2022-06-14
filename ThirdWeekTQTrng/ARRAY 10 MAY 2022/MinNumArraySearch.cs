using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class MinNumArraySearch
    {
        static void Main(string[] args)
        {

            int[] a = { 32, 65, 87, 12, 54, 90, 98 };
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min> a[i])                                               
                {
                    min = a[i];
                }
            }
            Console.WriteLine("MINIIMUM NUMBER IN THE GIVEN INTIGER ARRAY IS;" + min);
        }
    }
}
