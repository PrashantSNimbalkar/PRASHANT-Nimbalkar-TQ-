using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TableOfNumberForLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(num+"*"+i+"="+(num*i));
            }
        }

    }
}

