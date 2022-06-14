using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class STRING_ANAGRAM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE 1ST STRING");
            string str1 = Console.ReadLine();


            Console.WriteLine("ENTER THE 2ND STRING");
            string str2 = Console.ReadLine();


            string s1 = str1.ToLower();
            string s2 = str2.ToLower();

            char[] ch1 = s1.ToCharArray();
            char[] ch2 = s2.ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            Console.WriteLine(String.Join(" ",ch1));
            Console.WriteLine(String.Join(" ", ch2));

            String st1 = new string(ch1);
            String st2 = new string(ch2);


            if(st1.CompareTo(st2)==0)
            {
                Console.WriteLine(" BOTH THE STRINGS ARE ANAGRAM  ");
            }
            else
            {
                Console.WriteLine(" BOTH THE STRINGS ARE NOT ANAGRAM");
            }
        }
    }
}
