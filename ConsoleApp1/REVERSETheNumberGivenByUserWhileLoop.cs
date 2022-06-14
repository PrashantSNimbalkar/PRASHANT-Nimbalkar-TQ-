using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class REVERSETheNumberGivenByUserWhileLoop

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;

            while(num>0)
            {
                int r = num % 10;
                rev = rev * 10 + r;
                num = num / 10;
            }
            Console.WriteLine(rev);
        }
    }
}







