using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Count_Vowels_In_String
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str= Console.ReadLine();
            Console.WriteLine(str);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                if(str[i]=='a'|| str[i] =='e'|| str[i] =='i'|| str[i] =='o'|| str[i] =='u'|| str[i] =='A'|| str[i] =='E'|| str[i] =='I'|| str[i] =='O'|| str[i] =='U')
                {
                    count++;
                }
                
            }
            Console.WriteLine("THE NUMBER OF VOWELS IN THE STRING IS AS:   " + count);
        }
    }
}
