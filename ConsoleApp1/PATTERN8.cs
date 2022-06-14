using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*   ****
  *   ***
  *   **
  *   *      */
    class PATTERN8
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

