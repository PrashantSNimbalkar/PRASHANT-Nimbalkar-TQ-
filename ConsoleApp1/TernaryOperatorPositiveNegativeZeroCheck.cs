using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TernaryOperatorPositiveNegativeZeroCheck
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter The Number:");
            num = Convert.ToInt32(Console.ReadLine());
            string result;
            result = num > 0 ? "POSITIVE" : num < 0 ? "NEGATIVE" : "ZERO";
            Console.WriteLine("YOUR NUMBER IS:"+result);

        }
    }
}

