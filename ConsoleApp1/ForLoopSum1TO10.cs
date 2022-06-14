using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ForLoopSum1TO10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("Sum Of 1 To 10 IS:"+sum);
        }

    }
}


