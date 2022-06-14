using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.TESTNO2_8MAY2022
{
    class POWER_Calculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE BASE VALUE");
          int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE power value");
            int num2=Convert.ToInt32(Console.ReadLine());
            int power = 1;
            int i = 1;
            while(i<=num2)
            {
                power = power * num1;
                i++;
            }
            Console.WriteLine(power);
        }
    }
}
