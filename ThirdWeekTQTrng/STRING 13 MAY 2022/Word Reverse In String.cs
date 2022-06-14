using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class Word_Reverse_In_String
    {
        static void Main(string[] args)
        {
            string str = "MY NAME is Prashant";
            string[] mywords = str.Split("  ");
            string reverse = "  ";
            for(int i=0;i<mywords.Length;i++)
            {
                string s = mywords[i];
                string reversemywords = "  ";
                for(int j=s.Length-1;j>=0;j--)
                {
                    reversemywords = reversemywords + s[j];
                }
                reverse = reverse + reversemywords + " ";
            }
            Console.WriteLine(reverse);
        }
    }
}
