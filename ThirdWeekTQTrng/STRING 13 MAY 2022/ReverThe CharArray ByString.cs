using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class ReverThe_CharArray_ByString
    {
        static void Main(string[] args)
        {
            char[] ch = { 'I', 'N', 'D', 'I', 'A' };
            String s1 = new string(ch);
            Console.WriteLine(s1);
            string reverse = " ";
             for (int i=0;i<s1.Length;i++)
               {
                reverse = s1[i] + reverse;
               }
               Console.WriteLine(reverse);
               Console.WriteLine("*******************************************");

        }

    }
}
