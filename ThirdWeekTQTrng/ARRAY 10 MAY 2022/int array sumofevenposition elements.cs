using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class int_array_sumofevenposition_elements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE SIZE OF ARRAY");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            int sum = 0;
            Console.WriteLine("ENTER THE ELEMENTS OF ARRAY");
            for (int i = 0; i < a.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("************+++++***********");
            for (int i = 0; i < a.Length; i++)
            {   if(i%2==0)
                { sum = sum + a[i]; }
            }
            Console.WriteLine("SUM OF ALL ELEMENTS IN ARRAY IN EVEN POSITION IS=" + sum);
        }
    }
}
