using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DISARIUM_NUMBER
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            int count = 0;

            while (num>0)
            {
                count++;
                num = num / 10;
            }
            int sum = 0;
            num = temp;

            while (num>0)
            {
                int r = num % 10;
                int power = 1;
                for (int i=1;i<=count;i++)
                {
                    power = power * r;
                }
                sum = sum + power;
                num = num / 10;
                count--;
            }
            num = temp;
            if(sum==num)
            {
                Console.WriteLine("Number is Disarium Number ");
            }
            else
            {
                Console.WriteLine("Number is Not Disarium Number ");
            }
        }
    }
}
