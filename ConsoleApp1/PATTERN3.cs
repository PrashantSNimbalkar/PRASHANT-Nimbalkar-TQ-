using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*  1
  *  22
  *  333
  *  4444   */
    class PATTERN3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}


