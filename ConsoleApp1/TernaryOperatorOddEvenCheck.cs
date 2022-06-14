using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TernaryOperatorOddEvenCheck
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number:");
            num = Convert.ToInt32(Console.ReadLine());
            string Result;
            Result = (num % 2 == 0) ? "EVEN" : "ODD";
            Console.WriteLine("Your No is:" + Result);
        }
    }
}


