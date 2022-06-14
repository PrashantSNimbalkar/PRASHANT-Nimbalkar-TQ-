using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class STRING_PATTERN_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            Console.WriteLine("**************************************************");
            string[] s = str.Split();
            for (int i=0;i<s.Length;i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(s[j]+ "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
