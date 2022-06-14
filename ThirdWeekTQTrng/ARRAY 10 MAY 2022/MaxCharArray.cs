using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class MaxCharArray
    {
        static void Main(string[] args)
        {

            char[] ch = { 'a', 'z', 'f', 'r', 't', 'q' };
            char max = ch[0];
            for (int i = 0; i < ch.Length; i++)
            {
                if (max <ch[i])
                {
                    max = ch[i];
                }
            }
            Console.WriteLine("maximum character in given charb array is:" + max);
        }
    }
}
