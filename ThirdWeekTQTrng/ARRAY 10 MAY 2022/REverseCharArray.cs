using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class REverseCharArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
            Console.WriteLine("BEFORE DOING REVERSE PROCEDURE ORIGINAL ARRAY IS:");
            Console.WriteLine(String.Join("  ", ch));
            Console.WriteLine("******************************************************************");
            int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            Console.WriteLine("AHTER THE REVERSING PROCESS OF ARRAY IS:");
            Console.WriteLine(String.Join("  ", ch));
        }
    }
}
