using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PowersCalculationsWhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The BASE Value:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The EXPONENT OR PPOWER VALUE:");
            int expo = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            int i = 1;
            while(i<=expo)
            {
                power = power * num;
                i++;
            }
            Console.WriteLine(power);
        }
    }
}


