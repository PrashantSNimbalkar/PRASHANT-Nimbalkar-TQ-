using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class FREQUENCY_OF_WORD_IN_STRING
    {
        static void Main(string[] args)
        {
            
            
               Console.WriteLine("ENTER THE STRING");
                string str = Console.ReadLine();
                Console.WriteLine(str);
                Console.WriteLine("*********************************");
                Console.WriteLine("ENTER THE WORD FOR WHICH YOU WANT SEARCH FREQUENCY");
                string word = Console.ReadLine();
                string[] a = str.Split(' ');

                int count = 0;
                for(int i=0;i<a.Length;i++)
                {
                    if(word.Equals(a[i]))
                    {
                        count++;
                    }
     
                }
                Console.WriteLine("FREQUENCY OF GIVEN WORD IS:" + count);
           
        }
    }
}
