﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class CHECK_PRIME_NOTPRIME_NUM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The NUMBER:");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean isprime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                }
            }

            if (isprime == true)
            {
                Console.WriteLine("NUMBER IS PRIME NUMBER");
            }
            else
            {
                Console.WriteLine("NUMBER IS NOT PRIME NUMBER:");
            }
        }
    }
}