using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Count_The_Digits_From_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i]>='0'&& str[i]<='9')
                {
                    count++;
                }

            }
            Console.WriteLine("THE NUMBER OF Digits From string Is" +count);
        }
    }
}
