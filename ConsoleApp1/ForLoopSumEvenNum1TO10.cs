using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ForLoopSumEvenNum1TO10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}


