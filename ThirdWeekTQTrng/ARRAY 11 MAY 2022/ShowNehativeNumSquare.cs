using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class ShowNehativeNumSquare
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
            Console.WriteLine("ORIGINAL ARRAY IS AS FOLLOWS");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]); 
            }
            Console.WriteLine("******************************************************");
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]<0)
                {
                    a[i] = (a[i] * a[i]);
                }
            }
            Console.WriteLine("ARRAY SHOWS SQAURE OF NEGATIVR NUMBER CHANGR IN ORIGINAL ARRAY");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}