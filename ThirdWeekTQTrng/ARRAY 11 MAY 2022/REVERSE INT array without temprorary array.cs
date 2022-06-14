using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class REVERSE_INT_array_without_temprorary_array
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 90, 45,50,23,62 };
            Console.WriteLine("ORIGINAL ARRAY IS:");
            Console.WriteLine(String.Join("   ", a));
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            int i, j;
            j = a.Length - 1;
            for(i=0;i<a.Length/2;i++)
            {
                        a[i] = a[i] + a[j];
                        a[j] = a[i] - a[j];
                        a[i] = a[i] - a[j];
                        j--;
            }
            Console.WriteLine("ARRAY AFTER DOING REVERSE OPERATION");
             Console.WriteLine(String.Join("   ", a));
        }
    }
}
