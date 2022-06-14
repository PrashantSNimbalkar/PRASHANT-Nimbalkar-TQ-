using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class ReverseIntArray
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            Console.WriteLine(String.Join("  ", a));
            Console.WriteLine("******************************************");
            Console.WriteLine("ARRAY IN REVERSE ORDERE");
            for (int i = a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("******************************************");
            int j = a.Length - 1;
            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine("ARRA AFTER DOING REVERS ARRAY OPERATION:");
            Console.WriteLine("******************************************");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}

