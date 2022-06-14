using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class SearchArrayElementByUseCounter
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };
            Console.WriteLine("ENTER THE NUMBER YOU WANT TO SEARCH IN ARRAY");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (num == a[i])
                {
                    count++;
                    break;
                }
            }
            if (count!=0)
            {
                Console.WriteLine("NUMBER  " + num + "  IS PRESENT IN ARRAY");
            }
            else
            {
                Console.WriteLine("NUMBER  " + num + "is Not PRESENT IN ARRAY");
            }
        }
    }
}

