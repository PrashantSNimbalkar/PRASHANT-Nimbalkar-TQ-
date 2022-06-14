using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ForLoopSumOdd25To75
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 25; i <=75; i++)
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);

        }
    }
}


