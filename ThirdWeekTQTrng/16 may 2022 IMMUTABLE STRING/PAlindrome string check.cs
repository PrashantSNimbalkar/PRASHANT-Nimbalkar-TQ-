using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._16_may_2022_IMMUTABLE_STRING
{
    class PAlindrome_string_check
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello MY name is String");
            String name = sb.ToString().ToLower();
            string name2 = " ";
            Console.WriteLine("ORIGINAL ATRING IS:  "+name);
            for(int i=name.Length-1;i>=0;i--)
            {
                name2 = name2 + name[i];
            }
            Console.WriteLine("reverse STRING IS:  " + name2);
            if(name==name2)
            { Console.WriteLine("STRING IS PALINDROME"); }
            else
            {
                Console.WriteLine("STRING not IS PALINDROME");
            }
        }
    }
}
