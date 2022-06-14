using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Convert_Case_Array_toUPPERCASE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING IN CAPITAL LETTERS ONLY");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            string UPPER = "  ";
            int i;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    UPPER = UPPER + (char)(str[i] - 32);
                }
                else
                {
                    UPPER = UPPER + str[i];
                }

            }
            Console.WriteLine(UPPER);
        }
    }
}
