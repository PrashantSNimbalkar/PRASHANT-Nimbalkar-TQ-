using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Convert_Case_Array_to_Lowercasre
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING IN CAPITAL LETTERS ONLY");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            string lower = "  ";
            int i;
            for (i = 0; i < str.Length; i++)
            {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                lower = lower + (char)(str[i] + 32);
            }
            else
            {
                lower = lower + str[i];
            }

            }
            Console.WriteLine(lower);
        }
    }
}
