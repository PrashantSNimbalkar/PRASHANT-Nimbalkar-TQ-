using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PalindromeNumberCheckWhileLoop
    {
        static void Main(string[] args)
        {
            int num, r, sum = 0, temp;
            Console.WriteLine("Enter The NUMBER:");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("NUMBER IS A PALINDROME NUMBER");
            }
            else
            {
                Console.WriteLine("NUMBER IS NOT A PALINDROME NUMBER");
            }

        }
    }
}

