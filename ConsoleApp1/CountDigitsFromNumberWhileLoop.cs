using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CountDigitsFromNumberWhileLoop
    {
        static void Main(string[] args)
        {
            int count=0;
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("Number Of Digits In Given Number Is:"+count);
        }
    }
}
