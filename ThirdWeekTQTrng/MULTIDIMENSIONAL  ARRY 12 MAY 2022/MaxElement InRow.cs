using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class MaxElement_InRow
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 4, 6, 7 }, { 3, 5, 8 }, { 5, 8, 3 } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int max = a[i, 0];
  
              for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(max<a[i,j])
                    {
                        max = a[i, j];
                    }
                }
                Console.WriteLine("MACIMUM ELEMENT IN THE INDIVIAL ROWS IS ARE AS   "+max);
            }
        }
    }
}