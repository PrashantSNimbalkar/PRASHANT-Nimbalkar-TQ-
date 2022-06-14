using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class Repalce__num_with_immidiate_left_square_arrray
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 3, -19, 29, 5, -61, 44, 7, 49 };
            Console.WriteLine("ORIGINAL ARRAY IS:");
            Console.WriteLine(String.Join("   ", a));
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            for (int i = 1; i < a.Length; i++)
            {
                if(a[i]<0)
                {
                    a[i] = a[i - 1] * a[i - 1];
                }
            }
            Console.WriteLine("AFTER CHANGINGING EVERY negative num in array with its immidiate left num square");
            Console.WriteLine(String.Join("   ", a));
        }
    }
}
