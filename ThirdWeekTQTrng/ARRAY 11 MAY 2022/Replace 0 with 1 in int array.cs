using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class Replace_0_with_1_in_int_array
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            Console.WriteLine(  "ORIGINAL ARRAY IS:");
            Console.WriteLine(String.Join("   ", a));
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            for (int i=1;i<a.Length;i++)
            {
                if(a[i]==0)
                {
                    a[i] = 1;
                }
            }
            Console.WriteLine("AFTER CHANGINGING EVERY 0 TO 1 IN ARRAY THEN ARRAY IS:");
            Console.WriteLine(String.Join("   ", a));
        }
    }
}
