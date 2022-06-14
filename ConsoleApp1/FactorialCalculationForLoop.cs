using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FactorialCalculationForLoop
    {
        static void Main(string[] args)
        {
            int i, fact = 1;
            Console.WriteLine("Enter The NUMBER:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("FACTORIAL OF   " + num + "  is  " + fact);
        }
    }
}
