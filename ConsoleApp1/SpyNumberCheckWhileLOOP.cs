using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SpyNumberCheckWhileLOOP
    {
        static void Main(string[] args)
        {
            int num, product = 1, sum = 0, lastdigit;
            Console.WriteLine("Enter The Number:");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                lastdigit = num % 10;
                sum = sum + lastdigit;
                product = product * lastdigit;
                num = num / 10;
            }
            if(sum==product)
            {
                Console.WriteLine("Number Is A Spy Number:");
            }
            else
            {
                Console.WriteLine(" Number Is Not A Spy Number:");
            }
        }
    }
}

