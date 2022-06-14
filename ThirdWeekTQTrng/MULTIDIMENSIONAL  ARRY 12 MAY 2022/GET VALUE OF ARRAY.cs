using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class GET_VALUE_OF_ARRAY
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3, 4,  }, { 6, 7, 8, 9, }, { 11, 12, 13, 14,  }, { 16, 17, 18, 19,  }, { 21, 22, 23, 24,  } };
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************************************");
            int A = a.GetLength(0);
            int b = a.GetLength(1);
            
            int d = a.GetLowerBound(0);
            int e = a.GetLowerBound(1);
            
            int g = a.GetUpperBound(0);
            int h = a.GetUpperBound(1);
            
            Console.WriteLine(A);
            Console.WriteLine(b);
           
            Console.WriteLine(d);
            Console.WriteLine(e);
            
            Console.WriteLine(g);
            Console.WriteLine(h);
            

            










        }
    }
}
