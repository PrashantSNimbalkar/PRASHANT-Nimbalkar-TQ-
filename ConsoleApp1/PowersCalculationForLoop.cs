using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PowersCalculationForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The BASE Value:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The EXPONENT OR PPOWER VALUE:");
            int expo = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            
            for(int i=1;i<=expo;i++)
            {
                power = power * num; 
            }
            Console.WriteLine(power);
        }
    }
}
