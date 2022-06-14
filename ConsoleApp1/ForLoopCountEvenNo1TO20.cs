using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ForLoopCountEvenNo1TO20
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%2==0)
                {
                    Sum = Sum + 1;
                }
            }
            Console.WriteLine("NUMBER OF EVEN NUMBERS IN 1 TO 20 IS:"+Sum);
        }


    }
}


