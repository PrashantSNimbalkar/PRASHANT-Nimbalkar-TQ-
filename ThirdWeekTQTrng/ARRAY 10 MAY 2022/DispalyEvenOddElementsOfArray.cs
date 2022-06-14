using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class DispalyEvenOddElementsOfArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE SIZE OF ARRAY");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("ENTER THE ELEMENTS OF ARRAY");
            for (int i = 0; i < a.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("EVEN ELEMENTS OF aRRAY are:");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("****************************************************************");
            Console.WriteLine("ODD ELEMENTS OF ARRAY ARE AS FOLLOWS:");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 !=0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}

