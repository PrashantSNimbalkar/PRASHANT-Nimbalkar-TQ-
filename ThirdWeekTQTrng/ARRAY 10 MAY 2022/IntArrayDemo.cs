using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class IntArrayDemo
    {
        static void Main(string[] args)
        {
            int[] marks = { 343, 65, 98, 76, 09, 43, 23 };
            Console.WriteLine(String.Join("  ", marks));
            Console.WriteLine("**************************************************************");
            int[] b = new int[4];
            b[0] = 32;
            b[1] = 45;
            b[2] = 65;
            b[3] = 90;
            Console.WriteLine(String.Join("  ", b));
            Console.WriteLine("**************************************************************");

            int[] a = new int[4];
            Console.WriteLine("ENTER THE ARRAY ELEMENTS");
            for(int i=0;i<a.Length;i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
          /*    Console.WriteLine(a[i] + "  ");    */
            }
            Console.WriteLine("**************************************************************");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "  ");
            }
            Console.WriteLine("**************************************************************");
            foreach (int x in  a)
            {
                Console.WriteLine(x);
            }
        }
    }
}
