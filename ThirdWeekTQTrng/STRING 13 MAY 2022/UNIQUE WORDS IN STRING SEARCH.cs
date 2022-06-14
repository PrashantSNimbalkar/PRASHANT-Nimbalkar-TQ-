using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.STRING_13_MAY_2022
{
    class UNIQUE_WORDS_IN_STRING_SEARCH
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE STRING");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            string[] words = str.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;
                bool isvisited=false;

                for(int k=i-1;k>=0;k--)
                {
                    if(words[i]==words[k])
                    {
                        isvisited = true;
                        break;
                    }
                }
                for(int j=i+1;j<words.Length;j++)
                {
                    if(words[i] == words[j])
                    {
                        count++;
                    }
                }
                if(count==1)   //unique elements condition main case
                {
                    Console.WriteLine(words[i]+"  "+count);
                }

            }
        }
    }
}
