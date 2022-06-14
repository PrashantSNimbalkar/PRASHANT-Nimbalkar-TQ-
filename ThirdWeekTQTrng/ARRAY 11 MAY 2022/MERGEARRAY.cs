using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class MERGEARRAY
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };
            int[] b = { 11, 12, 13, 14, 15 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for(int i=0;i<a.Length;i++)
            {
                c[k] = a[i];
                k++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[k] = b[i];
                k++;
            }
            Console.WriteLine("MERGED ARRAY ELEMENT IS");
            for(int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}


