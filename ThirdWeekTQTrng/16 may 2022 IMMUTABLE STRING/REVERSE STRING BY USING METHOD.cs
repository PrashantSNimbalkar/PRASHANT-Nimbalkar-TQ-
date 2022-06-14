using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._16_may_2022_IMMUTABLE_STRING
{
    class REVERSE_STRING_BY_USING_METHOD
    {   public string doReverse(String str)
        {
            char[] ch = str.ToCharArray();//convert string into char array
            Array.Reverse(ch);//reversr the array using Function Reeverse
            return new string(ch);  //ANNONYMOUS METHOD WHO DONT HAVE NAME
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            String s= Console.ReadLine();
            REVERSE_STRING_BY_USING_METHOD rs = new REVERSE_STRING_BY_USING_METHOD();//object creatrteed oh class
            Console.WriteLine(rs.doReverse(s));
        }
    }
}
