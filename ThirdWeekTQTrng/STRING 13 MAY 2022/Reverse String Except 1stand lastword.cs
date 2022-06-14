using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Reverse_String_Except_1stand_lastword
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine("******************************");
          
            string[]str = s.Split(" ");
           
            string reverseword = " ";
            
            for(int i=1;i<str.Length-1;i++)
            {
                string word = str[i];
                string reverse = " ";
                for(int j=word.Length-1;j>=0;j--)
                {
                    reverse = reverse + word[j];

                }
                reverseword = reverseword + reverse + " ";
            }
            Console.WriteLine(reverseword);
            Console.WriteLine("************************************************************");
            Console.WriteLine(str[0] + " " + reverseword + " " + str[str.Length - 1]);


        }
    }
}
