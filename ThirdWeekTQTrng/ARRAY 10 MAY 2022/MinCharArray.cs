using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class MinCharArray
    {
        static void Main(string[] args)
        {

            char[] ch = { 'a', 'z', 'f', 'r', 't', 'q' };
            char min = ch[0];
            for(int i=0;i<ch.Length;i++)
            {
                if(min>ch[i])
                {
                    min = ch[i];
                }
            }
            Console.WriteLine(" minimum character in given char array is:" + min);
        }
    }
}
