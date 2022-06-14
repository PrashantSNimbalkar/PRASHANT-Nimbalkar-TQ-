using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng._2_june_22_advanve_trng_day_1
{
    class String_to_ToogleCase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine("ORIGINAL STRING IS ==  "+str);
            char[] ch = str.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                if(ch[i]>='A'&& ch[i]<='Z')
                {
                    ch[i] = (char)(ch[i] + 'a' - 'A');
                }
                else if(ch[i] >= 'a' && ch[i] <= 'z')
                {
                    ch[i] = (char)(ch[i] + 'A' - 'a');
                }
            }
            Console.WriteLine("STRING AFTER TOGGLE OPERATION IN TOGGLE CASE IS");
            Console.WriteLine(String.Join("", ch));
        }
    }
}