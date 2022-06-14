using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*      *
  *      **
  *     ***      */
    class PATTERN11
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=3;i++)
            {
                for(int k=3;k>i;k--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}




