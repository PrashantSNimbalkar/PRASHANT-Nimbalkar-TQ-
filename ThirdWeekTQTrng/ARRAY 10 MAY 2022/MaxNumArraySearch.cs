using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class MaxNumArraySearch
    {
        static void Main(string[] args)
        {

            int[] a = { 32, 65, 87, 12, 54, 90, 98 };
            int max = a[0];
            for (int i = 0; i <a.Length;i++)
            {
                if (max <a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("MAX NUM N INT TYPE ARRAY IS:" + max);
        }
    }
}
