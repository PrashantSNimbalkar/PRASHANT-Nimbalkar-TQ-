using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class SumOfAllArrayElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE SIZE OF ARRAY");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int sum = 0;
            Console.WriteLine("ENTER THE ELEMENTS OF ARRAY");
            for (int i = 0; i < a.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("****************************************************************");
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("SUM OF ALL ELEMENTS IN ARRAY IS:" + sum);
        }
    }
}
