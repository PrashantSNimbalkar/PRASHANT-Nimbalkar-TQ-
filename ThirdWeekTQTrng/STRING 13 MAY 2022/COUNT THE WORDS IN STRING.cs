using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class COUNT_THE_WORDS_IN_STRING
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            string[] words = str.Split(" ");
            Console.WriteLine("NUMBER OF WORDS IN THE STRING IS ARE    "+words.Length);
        }
    }
}
