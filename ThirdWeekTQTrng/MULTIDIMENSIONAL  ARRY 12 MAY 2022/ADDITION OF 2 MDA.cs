using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.MULTIDIMENSIONAL__ARRY_12_MAY_2022
{
    class ADDITION_OF_2_MDA
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            Console.WriteLine("Enter The Array 1 Elements");
            for (int i = 0; i < a.GetLength(0); i++)
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
            Console.WriteLine("*********************************************************");
            int[,] b = new int[3, 3];
            Console.WriteLine("Enter The Array 2 Elements");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************************************");

            int[,] sum = new int[3, 3];
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }

            }
            Console.WriteLine("ADDITION OF FIRST 2 ARRAYS IS STORED IN ARRARY THIRD ARRAY THIS ARRAY SUM ELEMENTS ARE ");
            Console.WriteLine("*********************************************************");
            for (int i = 0; i < sum.GetLength(0); i++)
            {
                for (int j = 0; j < sum.GetLength(1); j++)
                {
                    Console.Write(sum[i, j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
