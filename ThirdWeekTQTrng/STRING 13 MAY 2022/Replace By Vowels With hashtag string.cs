using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Replace_By_Vowels_With_hashtag_string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            
            string replace = " ";
            for (int i = 0; i < str.Length; i++)
            {
                
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    replace = replace + '#';
                }
                else
                {
                    replace = replace + str[i];
                }

            }
            Console.WriteLine("STRING REPLACE VOWELS WITH #");
            Console.WriteLine(replace);
        }
    }
}
