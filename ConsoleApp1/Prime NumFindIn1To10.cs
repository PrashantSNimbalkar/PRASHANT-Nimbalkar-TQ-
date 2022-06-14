using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Prime_NumFindIn1To10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The NUMBER UPTO WHICH You Have To find Prime Numbers:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i =2; i <= n; i++)
            {
                Boolean flag = true;
                
                for(int j=2;j<=i-1;j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    }
                    
                }
                if(flag==true)
                {
                    Console.Write(i+" ");
                }

            }
        }
    }
}

