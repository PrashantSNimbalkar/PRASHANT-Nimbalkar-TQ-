using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*    4321
  *    432
  *    43
  *    4      */
    class PATTERN10
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<=4; i++)
            {
                for (int j = 4; j>=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}


