using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.TESTNO2_8MAY2022
{
    class FREQUENCY_DIGIT_MOBILE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Mobile Number");
            string mnum = Console.ReadLine();
            long num = long.Parse(mnum);
            long count, digit, temp, i;
            for(i=0;i<=9;i++)
            {
                count = 0;
                temp = num;
                while(temp>0)
                {
                    digit = temp % 10;
                    if(digit==i)
                    {
                        count++;
                    }
                }
                if(count>0)
                {
                    Console.WriteLine(i + "   " + count);
                }

            }
        }

    }
}
