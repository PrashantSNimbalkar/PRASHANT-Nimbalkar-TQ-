using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class REVERSR_THE_STRING
    {
        static void Main(string[] args)
        {
            string str = "India Is My Country";
            string reverse = " ";
         /* for (int i=0;i<str.Length;i++)
            {
                reverse = str[i] + reverse;
            }
            Console.WriteLine(reverse);
            Console.WriteLine("*******************************************");*/
            for(int i=str.Length-1;i>=0;i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
        }
        
    }
}
