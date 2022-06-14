using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{/*           1
  *          333
  *//*      555555        */ 
                   
    class PATTERN18
    {
        static void Main(string[] args)
        {
            int n=3,z=1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k=1; k<=z; k++)
                {
                    Console.Write(z);
                }
                z = z + 2;
                Console.WriteLine();
            }

        }
    }
}


