using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PATTERNCHAR1
    {/*   A
      *   
      *   A
      *   B
      *   
      *   A
      *   B
      *   C
      *   
      *   A
      *   B
      *   C
      *   D     */
        static void Main(string[] args)
        {
            for(char i='A';i<='D';i++)
            {
                for(char j='A';j<=i;j++)
                {
                    Console.Write(j);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}

