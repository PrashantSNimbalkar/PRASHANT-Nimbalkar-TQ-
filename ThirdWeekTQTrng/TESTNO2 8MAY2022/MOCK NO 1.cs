using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdWeekTQTrng.TESTNO2_8MAY2022
{
    class MOCK_NO_1
    {
        static void Main(string[] args)
        {
            int r;
            int temp = 0;
            Console.WriteLine("Enter THE Number");
            int num;
             num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                r = num % 10;
               if(r>temp)
                {
                   temp = r;

                }
                
                num = num / 10;
            }
            Console.WriteLine(temp);
               
        }
    }
}
