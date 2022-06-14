using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class HAPPY_NUM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE NUM");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean ishappy = true;
            for (; num > 0; num = num / 10)
            {
                int h = num % 10;
                if (h % 2 == 0)
                {
                    ishappy = false;
                }
            }
            if (ishappy == true)
            {
                Console.WriteLine("Happy");

            }
            else
            {
                Console.WriteLine("Not Happy");
            }
        }
    }
}
