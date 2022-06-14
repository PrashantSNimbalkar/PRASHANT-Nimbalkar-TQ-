using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{                           /*     1
                             *     23
                             *     456
                             */
    class Pattern17
    {
        static void Main(string[] args)
        {
            int x = 1;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(x);
                    x++;
                }
                Console.WriteLine();
            }
            
        }
    }
}

