using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*    A
  *    AB
  *    ABC
  *    ABCD    */
    class PATTERNchar2
    {
        static void Main(string[] args)
        {
            int ch = 64;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(j + ch));
                }
                Console.WriteLine();
            }

        }
    }
}

