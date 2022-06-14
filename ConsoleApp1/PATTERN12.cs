using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*     1
  *     10
  *     101
  *     1010
  *     10101   */
    class PATTERN12
    {
        static void Main(string[] args)
        {
            int i, j, rows = 5;
            for(i=1;i<=rows;i++)
            {
                for (j =1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write(1);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

