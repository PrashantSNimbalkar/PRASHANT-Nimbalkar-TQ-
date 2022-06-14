using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class String_creation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1);


            string s = "hello everone";//using keyword mannually//
            Console.WriteLine(s);

            String str = "WELCOME TO INDIA";//using Systeme.String//
            Console.WriteLine(str);

            String s2 = new string("MY C PLUS PLUS");  //using new//
            Console.WriteLine(s2);


            char[] ch = { 'I', 'N', 'D', 'I', 'A' };
            String s3 = new string(ch);//create string by passing character array//
            Console.WriteLine(s3);
        }
    }
}
