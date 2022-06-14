using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class UPPER_TRAIANGLE_PATTERN
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 4, 6, 7, 7 }, { 3, 5, 8, 8 }, { 5, 8, 3, 8 }, { 1, 2, 4, 6 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*****************************************************");
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j>i)
                    {
                        Console.Write(a[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                    Console.WriteLine();
                }

            }


        }
    }
}
