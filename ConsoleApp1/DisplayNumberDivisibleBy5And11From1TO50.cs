using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DisplayNumberDivisibleBy5And11From1TO50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers In 1 TO 50 Which Is Divisible By 5 AND 11:");
            for(int i=1;i<=50;i++)
            {
                if((i%5==0)&&(i%11==0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
