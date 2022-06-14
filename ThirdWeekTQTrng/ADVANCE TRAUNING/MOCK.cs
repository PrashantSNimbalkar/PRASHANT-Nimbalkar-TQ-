using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ADVANCE_TRAUNING
{
    class MOCK
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] { 10, 20, 30, 40 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("*********************************");
            for (int i = 0; i <= arr.Length / 2; i++)
            {
                for (int j = arr.Length - 1; j >= arr.Length / 2; j--)
                {
                    int temp = arr[i];
                    int temp2 = arr[j];
                    arr[i] = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp2;
                    arr[j] = temp;
                }
                
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
