using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class KRISHNAMURTI_NUMBER
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num>0)
            {
                int r = num % 10;
                int fact = 1;
                for(int i=1;i<=r; i++)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Number IS KRISHNAMURTI NUMBER:");
            }
            else
            {
                Console.WriteLine("Number IS Not KRISHNAMURTI NUMBER:");
            }
        }
       
    }
}


