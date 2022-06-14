using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DisplayEvery7thNumberFrom1To50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EVERY 7TH NUMBER IN 1 TO 50 IS:");
            Console.WriteLine(1);
            for(int i=0;i<=50;i=i+7)
            {
                if(i==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}




