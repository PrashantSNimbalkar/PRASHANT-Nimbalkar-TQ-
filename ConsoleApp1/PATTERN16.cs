using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*         *
  *         *
  *       *****
  */   /*   *
            *    */
    class PATTERN16
    {
        static void Main(string[] args)
        {
            int i, j, rows = 5;
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= rows; j++)
                {
                    if ( j == 3 || i == 3 )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

