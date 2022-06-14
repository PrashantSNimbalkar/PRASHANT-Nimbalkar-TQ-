using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class MULTI_D_ARRAY_DEMO
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            Console.WriteLine("Enter The Array Elements");
            for(int i=0;i<a.GetLength(0);i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
               
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                       Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*************************************************");
            foreach (int C in a)
            {
                Console.Write(C+"  ");
                
            }
            Console.WriteLine("*************************************************");
            for (int i = 0; i < a.GetUpperBound(0); i++)
            {
                for (int j = 0; j < a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
