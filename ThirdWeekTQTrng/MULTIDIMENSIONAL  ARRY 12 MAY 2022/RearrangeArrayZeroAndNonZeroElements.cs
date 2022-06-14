using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class RearrangeArrayZeroAndNonZeroElements
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 2, 0, 4, 0, 6, 0, 7, 8, 4, 0, 0, 0, 0, 0, 0, 0, 0, 2, 7, 9, 7, 3, 9 };
            Console.WriteLine(  "original array is");
            Console.WriteLine(String.Join(" ", a));
            Console.WriteLine("*******************************************");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] > 0)
                        {
                            int temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                            break;
                        }
                    }

                }
            }
            Console.WriteLine("After Doing Reshuflling Of Array then Array Is");
            Console.WriteLine(String.Join(" ",a));
        }
    }
}
