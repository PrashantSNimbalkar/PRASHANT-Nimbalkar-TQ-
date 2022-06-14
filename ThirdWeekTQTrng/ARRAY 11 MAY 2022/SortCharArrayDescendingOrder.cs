using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.ARRAY_11_MAY_2022
{
    class SortCharArrayDescendingOrder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE SIZE OF ARRAY");
            int size = Convert.ToInt32(Console.ReadLine());
            char[] ch = new char[size];
            Console.WriteLine("ENTER THE ELEMENTS OF ARRAY");
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = Console.ReadLine()[0];
            }
            Console.WriteLine(String.Join("   ", ch));
            for(int i=0;i<ch.Length;i++)
            {
                for(int j=i+1;j<ch.Length;j++)
                {
                    if(ch[i]<ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                        

                    }
                }
            }
            Console.WriteLine("*************************************************************");
            Console.WriteLine(String.Join("   ", ch));
        }
    }
}

