using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_10_MAY_2022
{
    class CharArrayDisplay3methods
    {
        static void Main(string[] args)
        {

            char[] ch = { 'a', 'd', 'f', 'g', 'h' };
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("*************************************************************");
            Array.ForEach(ch, Console.WriteLine);
            Console.WriteLine("*************************************************************");
            Console.WriteLine(String.Join("  ", ch));
            Console.WriteLine("*************************************************************");
            Console.WriteLine(String.Join(",", ch));
            Console.WriteLine("*************************************************************");
        }
    }
}
