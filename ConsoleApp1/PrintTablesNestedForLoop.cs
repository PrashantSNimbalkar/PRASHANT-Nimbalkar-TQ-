using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PrintTablesNestedForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The NUMBER UPTO WHICH YOU HAVE TO PRINT TABLE:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++) 

            {
                for(int j=1;j<=10;j++)
                {
                    Console.Write(i*j+" ");
                    
                }
                Console.WriteLine();
            }

        }

    }
}
