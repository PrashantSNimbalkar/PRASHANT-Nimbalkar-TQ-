using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class SUM_OF_DIGITS_IN_A_STRING
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine(str);
        
            int sum = 0;
                int i;
            for (i=0;i<str.Length;i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    int x = int.Parse(str[i].ToString());
                    sum = sum + x;
                }
            }
            Console.WriteLine("SUM OF DIGITS IN THE STRING IS:   "+sum);
        }
    }
}
