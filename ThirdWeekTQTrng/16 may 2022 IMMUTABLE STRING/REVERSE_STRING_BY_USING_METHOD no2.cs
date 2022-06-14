using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._16_may_2022_IMMUTABLE_STRING
{
    class REVERSE_STRING_BY_USING_METHOD_no2
    {
        public string doReverse(String str)
        {
            char[] ch = str.ToCharArray();//convert string into char array
            Array.Reverse(ch);//reversr the array using Function Reeverse
            String st = new string(ch);//array ch passed to string st
            return st;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            String s = Console.ReadLine();
            Console.WriteLine(new REVERSE_STRING_BY_USING_METHOD_no2().doReverse(s));
            
        }
    }
}
